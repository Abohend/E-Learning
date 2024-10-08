using Learn.Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;


namespace Learn.DataAccess.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Enrollment>()
                .HasKey(e => new { e.ApplicationUserId, e.CourseId });
            //API Flunt Course with FeedBack  1 => M
            builder.Entity<Feedback>()
                .HasOne(e => e.Course)
                .WithMany(f => f.Feedbacks)
                .HasForeignKey(f => f.CourseId);

            //API Flunt User with FeedBack  1 => M
            builder.Entity<Feedback>()
               .HasOne(f => f.User)
               .WithMany(u => u.Feedbacks)
               .HasForeignKey(f => f.ApplicationUserId);



        }

    }
    
        

}
