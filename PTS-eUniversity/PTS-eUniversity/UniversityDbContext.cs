using PTS_eUniversity.Models;
using System.Data.Entity;

namespace PTS_eUniversity
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext() : base("DefaultConnection") { }

        public DbSet<User> Users { get; set; }

        public DbSet<Faculty> Faculties { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Endorsement> Endorsements { get; set; }

        public DbSet<Insurance> Insurances { get; set; }

        public DbSet<StudentGrade> Grades { get; set; }
    }
}