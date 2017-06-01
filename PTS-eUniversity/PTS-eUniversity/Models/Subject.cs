using System.Collections.Generic;

namespace PTS_eUniversity.Models
{
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int FacultyId { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual List<Endorsement> Endorsements { get; set; }

        public virtual List<StudentGrade> Grades { get; set; }
    }
}