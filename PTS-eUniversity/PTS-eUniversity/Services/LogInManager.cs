using Microsoft.Owin;
using PTS_eUniversity.ViewModels;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;

namespace PTS_eUniversity.Services
{
    public class LogInManager
    {
        public bool TryAuthenticate(LogInModel model, IOwinContext context)
        {
            var db = new UniversityDbContext();
            var user = db.Users.Where(u => u.Email == model.Email).FirstOrDefault();

            if (user != null && PasswordHasher.ValidatePassword(model.Password, user.Password))
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.FirstName),
                    new Claim(ClaimTypes.Email, user.Email)
                }, "ApplicationCookie");

                var authManager = context.Authentication;
                authManager.SignIn(identity);

                return true;
            }

            return false;
        }

        public bool TryLogOut(IPrincipal principal, IOwinContext context)
        {
            if (principal.Identity.IsAuthenticated)
            {
                var authManager = context.Authentication;
                authManager.SignOut("ApplicationCookie");

                return true;
            }

            return false;
        }
    }
}