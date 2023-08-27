using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.MVC.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<Courses> Course { get; set; }
       
        public DbSet<Lectures> Lectures { get; set; }   

        public DbSet<Student> Students { get; set; }

        public DbSet<Classes> Classes { get; set; }

        public DbSet<Enrollments> Enrollments { get; set; } 


    
    }
}
