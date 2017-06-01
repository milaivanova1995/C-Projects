using System.Security.Claims;
using System.Web.Mvc;
using System.Linq;

namespace PTS_eUniversity.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Index()
        {
            var db = new UniversityDbContext();
            var identity = User.Identity as ClaimsIdentity;
            var email = identity.FindFirst(ClaimTypes.Email).Value;

            var user = db.Users.Where(x => x.Email == email).FirstOrDefault();
            return View(user);
        }
    }
}