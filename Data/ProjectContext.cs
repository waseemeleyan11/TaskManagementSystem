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

        // DbSets for the models
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ProjectUser relationships

            modelBuilder.Entity<ProjectUser>()
            .HasKey(pu => new { pu.UserId, pu.ProjectId });

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.User)
                .WithMany(u => u.ProjectUsers)
                .HasForeignKey(pu => pu.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.Project)
                .WithMany(p => p.ProjectUsers)
                .HasForeignKey(pu => pu.ProjectId).OnDelete(DeleteBehavior.Restrict);

            // UserTask relationships
            modelBuilder.Entity<UserTask>()
            .HasKey(ut => new { ut.UserId, ut.TaskId });

            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.User)
                .WithMany(u => u.UserTasks)
                .HasForeignKey(ut => ut.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.Task)
                .WithMany(t => t.UserTasks)
                .HasForeignKey(ut => ut.TaskId).OnDelete(DeleteBehavior.Restrict);

            // Project relationships
            modelBuilder.Entity<Project>()
                .HasOne(p => p.User)
                .WithMany(u => u.Projects)
                .HasForeignKey(p => p.UserId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.Attachment)
                .WithOne(a => a.Project)
                .HasForeignKey<Project>(p => p.AttachmentId).OnDelete(DeleteBehavior.Restrict);

            // Agile relationships
            modelBuilder.Entity<Agile>()
                .HasMany(a => a.Sprints)
                .WithOne(s => s.Agile)
                .HasForeignKey(s => s.AgileId).OnDelete(DeleteBehavior.NoAction);

            // Waterfall relationships
            modelBuilder.Entity<Waterfall>()
                .HasMany(w => w.Tasks)
                .WithOne(t => t.Waterfall)
                .HasForeignKey(t => t.WaterfallId).OnDelete(DeleteBehavior.Restrict);

            // Sprint relationships
            modelBuilder.Entity<Sprint>()
                .HasOne(s => s.User)
                .WithMany(u => u.Sprints)
                .HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Sprint>()
                .HasMany(s => s.Tasks)
                .WithOne(t => t.Sprint)
                .HasForeignKey(t => t.SprintId).OnDelete(DeleteBehavior.Restrict);

            // Task relationships
            modelBuilder.Entity<Task>()
                .HasOne(t => t.Sprint)
                .WithMany(s => s.Tasks)
                .HasForeignKey(t => t.SprintId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.Waterfall)
                .WithMany(w => w.Tasks)
                .HasForeignKey(t => t.WaterfallId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.Attachment)
                .WithOne(a => a.Task)
                .HasForeignKey<Task>(t => t.AttachmentId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Task>()
                .HasMany(t => t.Comments)
                .WithOne(c => c.Task)
                .HasForeignKey(c => c.TaskId).OnDelete(DeleteBehavior.Restrict);

            // Comment relationships
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.UserId);
            // Inheritance configuration
            modelBuilder.Entity<Agile>()
                .ToTable("AgileProjects");

            modelBuilder.Entity<Waterfall>()
                .ToTable("WaterfallProjects");

            base.OnModelCreating(modelBuilder);
        }
    }
}