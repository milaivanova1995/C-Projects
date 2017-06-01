using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace PTS_eUniversity.Controllers
{
    public class EndorsementsController : Controller
    {
        public ActionResult Index()
        {
            var identity = User.Identity as ClaimsIdentity;
            var email = identity.FindFirst(ClaimTypes.Email).Value;

            var endorsements = GetEndorsements(email);
            return View(endorsements);
        }

        private Dictionary<string, bool> GetEndorsements(string email)
        {
            var db = new UniversityDbContext();
            Dictionary<string, bool> endorsements = new Dictionary<string, bool>();

            var user = db.Users.Where(x => x.Email == email).FirstOrDefault();
            if (user != null)
            {
                var subjects = db.Subjects.Where(x => x.FacultyId == user.FacultyId);
                var _endorsements = db.Endorsements.Where(x => x.User.Email == email);

                foreach (var subject in subjects)
                {
                    endorsements[subject.Name] = _endorsements.Any(x => x.SubjectId == subject.Id);
                }
            }

            return endorsements;
        }
    }
}