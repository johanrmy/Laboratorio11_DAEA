using Microsoft.EntityFrameworkCore;

namespace Laboratorio11.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAB1504-21\\SQLEXPRESS; Initial Catalog=SchoolDB; Integrated Security=True; trustservercertificate=True");
        }

    }
}
