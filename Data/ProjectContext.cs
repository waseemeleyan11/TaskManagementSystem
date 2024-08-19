using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Data.Models;
using Task = TaskManagementSystem.Data.Models.Task;
namespace TaskManagementSystem.Data
{
    public class ProjectContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public ProjectContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User-Project (Many-to-Many) Configuration
            modelBuilder.Entity<ProjectUser>()
                .HasKey(pu => new { pu.userId, pu.projectId });

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.User)
                .WithMany(u => u.ProjectUsers)
                .HasForeignKey(pu => pu.UserId);

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.Project)
                .WithMany(p => p.projectUsers)
                .HasForeignKey(pu => pu.projectId);

            // User-Task (Many-to-Many) Configuration
            modelBuilder.Entity<UserTask>()
                .HasKey(ut => new { ut.UserId, ut.TaskId });

            modelBuilder.Entity<UserTask>()
                        .HasOne(ut => ut.Users)
                        .WithMany(u => u.UserTasks)
                        .HasForeignKey(ut => ut.UserId);

            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.Tasks)
                .WithMany(t => t.UserTasks)
                .HasForeignKey(ut => ut.TaskId);

            // User-Comment (One-to-Many) Configuration
            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Task-Comment (One-to-Many) Configuration
            modelBuilder.Entity<Task>()
                .HasMany(t => t.Comments)
                .WithOne(c => c.Task)
                .HasForeignKey(c => c.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            // User-Sprint (One-to-Many) Configuration
            modelBuilder.Entity<User>()
                .HasMany(u => u.Sprints)
                .WithOne(s => s.User)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Agile-Sprint (One-to-Many) Configuration
            modelBuilder.Entity<Agile>()
                .HasMany(a => a.Sprints)
                .WithOne(s => s.Agile)
                .HasForeignKey(s => s.AgileId)
                .OnDelete(DeleteBehavior.Cascade);

            // User-Attachment (One-to-One) Configuration
            modelBuilder.Entity<User>()
                .HasOne(u => u.Attachment)
                .WithOne(a => a.User)
                .HasForeignKey<User>(u => u.AttachmentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Waterfall-Task (One-to-Many) Configuration
            modelBuilder.Entity<Waterfall>()
                .HasMany(w => w.Tasks)
                .WithOne(t => t.Waterfall)
                .HasForeignKey(t => t.WaterfallId)
                .OnDelete(DeleteBehavior.Cascade);
        }

        // DbSets for the 10 Models
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectUser> ProjectUsers { get; set; }
        public DbSet<Agile> Agiles { get; set; }
        public DbSet<Waterfall> Waterfalls { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }
    }
}