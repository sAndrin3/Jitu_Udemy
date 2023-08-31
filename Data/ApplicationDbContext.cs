using Jitu_Udemy.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jitu_Udemy.Data{
    public class ApplicationDbContext : DbContext{
        public DbSet<User> Users {get; set; }
        public DbSet<Course> Courses {get; set; }
        public DbSet<Instructor> Instructors {get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    }
}