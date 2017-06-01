using System.Collections.Generic;

namespace PTS_eUniversity.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual List<Endorsement> Endorsements { get; set; }

        public virtual List<Insurance> Insurances { get; set; }

        public virtual List<StudentGrade> Grades { get; set; }
    }
}