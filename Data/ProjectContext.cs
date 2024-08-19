using Microsoft.EntityFrameworkCore;

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
            modelBuilder.Entity<User>()
            .HasOne(u => u.Attachment)          // Each User has one Attachment
            .WithOne(a => a.User)               // Each Attachment has one User
            .HasForeignKey<User>(u => u.AttachmentId) // Foreign key in User table
            .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<User>().HasMany(u => u.Projects)
              //  .WithOne(p => p.User).HasForeignKey(p => p.userId).OnDelete(DeleteBehavior.Cascade);

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
           .WithOne(c => c.User)       // Each Comment has one User
           .HasForeignKey(c => c.UserId)  // Foreign key in Comment table
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
           .HasOne(t => t.Agile)    // A Task has many Comments
           .WithOne(c => c.User)       // Each Comment has one Task
           .HasForeignKey<Agile>(c => c.userId)  // Foreign key in Comment table
           .OnDelete(DeleteBehavior.Cascade);

            // Agile-Sprint (One-to-Many) Configuration
            modelBuilder.Entity<Agile>()
            .HasMany(u => u.Sprints)    // A User has many Tasks
            .WithOne(t => t.Agile)    // Each Task has one User
            .HasForeignKey(t => t.AgileId)  // Foreign key in Task table
            .OnDelete(DeleteBehavior.Cascade);

            /////
            modelBuilder.Entity<User>()
           .HasMany(u => u.Tasks)
           .WithOne(c => c.User)       // Each Comment has one User
           .HasForeignKey(c => c.UserId)  // Foreign key in Comment table
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
           .HasOne(t => t.Waterfall)    // A Task has many Comments
           .WithOne(c => c.User)       // Each Comment has one Task
           .HasForeignKey<Waterfall>(c => c.userId)  // Foreign key in Comment table
           .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Waterfall>()
            .HasMany(u => u.Tasks)    // A User has many Tasks
            .WithOne(t => t.Waterfall)    // Each Task has one User
            .HasForeignKey(t => t.ProjectId)  // Foreign key in Task table
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