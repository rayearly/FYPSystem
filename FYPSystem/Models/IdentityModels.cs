using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FYPSystem.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<SupervisorStudents> StudentSupervisors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Semester> Semesters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Student>()
                .HasRequired(s => s.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(s => s.CourseId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<Student>()
                .HasRequired(s => s.Semester)
                .WithMany(e => e.Students)
                .HasForeignKey(s => s.SemesterId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<Student>()
                .HasRequired(s => s.Faculty)
                .WithMany(e => e.Students)
                .HasForeignKey(s => s.FacultyId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .Entity<SupervisorStudents>()
                .HasKey(a =>
                    new
                    {
                        a.StudentId, a.SupervisorId
                    }
                );


            base.OnModelCreating(modelBuilder);
        }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}