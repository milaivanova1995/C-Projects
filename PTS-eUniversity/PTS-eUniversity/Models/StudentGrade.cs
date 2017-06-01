namespace PTS_eUniversity.Models
{
    public class StudentGrade
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }

        public int Grade { get; set; }
    }
}