using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;

namespace PTS_eUniversity.Controllers
{
    public class GradesController : Controller
    {
        public ActionResult Index()
        {
            var db = new UniversityDbContext();
            var identity = User.Identity as ClaimsIdentity;
            var email = identity.FindFirst(ClaimTypes.Email).Value;

            var grades = db.Grades.Where(x => x.User.Email == email).ToList();
            return View(grades);
        }
    }
}