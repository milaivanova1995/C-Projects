using System.Linq;
using System.Security.Claims;
using System.Web.Mvc;

namespace PTS_eUniversity.Controllers
{
    public class InsurancesController : Controller
    {
        public ActionResult Index()
        {
            var db = new UniversityDbContext();
            var identity = User.Identity as ClaimsIdentity;
            var email = identity.FindFirst(ClaimTypes.Email).Value;

            var insurances = db.Insurances.Where(x => x.User.Email == email).ToList();
            return View(insurances);
        }
    }
}