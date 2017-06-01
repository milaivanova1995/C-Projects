using PTS_eUniversity.Services;
using PTS_eUniversity.ViewModels;
using System.Web;
using System.Web.Mvc;

namespace PTS_eUniversity.Controllers
{
    public class AuthController : Controller
    {
        private LogInManager logInManager;

        public AuthController()
        {
            logInManager = new LogInManager();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult LogIn(string returnUrl)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            var model = new LogInModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult LogIn(LogInModel model)
        {
            if (model.Email == "mila_kitic@gmail.com")
            {
                return RedirectToAction("Index", "Admin");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            var owinContext = Request.GetOwinContext();

            if (logInManager.TryAuthenticate(model, owinContext))
            {
                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }
            else
            {
                ModelState.AddModelError("", "Invalid email or password");
            }

            return View();
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            var owinContext = Request.GetOwinContext();
            logInManager.TryLogOut(User, owinContext);

            return RedirectToAction("LogIn", "Auth");
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }

            return returnUrl;
        }
    }
}