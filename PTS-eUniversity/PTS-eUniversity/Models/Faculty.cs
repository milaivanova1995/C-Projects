using System.Collections.Generic;

namespace PTS_eUniversity.Models
{
    public class Faculty
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Subject> Subjects { get; set; }
    }
}