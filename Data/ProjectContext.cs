using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Data.Models;
using Task = TaskManagementSystem.Data.Models.Task;


//>>>>>>> b14d04820704608e9f3058714677eb101c5d41b0
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
            //base.OnModelCreating(modelBuilder);

            //<<<<<<< HEAD
            // User-Project (Many-to-Many) Configuration
            //modelBuilder.Entity<ProjectUser>()
            //    .HasKey(pu => new { pu.userId, pu.projectId });

            //modelBuilder.Entity<ProjectUser>()
            //    .HasOne(pu => pu.User)
            //    .WithMany(u => u.ProjectUsers)
            //    .HasForeignKey(pu => pu.userId);

            //modelBuilder.Entity<ProjectUser>()
            //    .HasOne(pu => pu.Project)
            //    .WithMany(p => p.ProjectUsers)
            //    .HasForeignKey(pu => pu.projectId);

            // User-Task (Many-to-Many) Configuration
            //            modelBuilder.Entity<UserTask>()
            //                .HasKey(ut => new { ut.UserId, ut.TaskId });

            //            modelBuilder.Entity<UserTask>()
            //                        .HasOne(ut => ut.Users)
            //                        .WithMany(u => u.UserTasks)
            //                        .HasForeignKey(ut => ut.UserId);

            //            modelBuilder.Entity<UserTask>()
            //                .HasOne(ut => ut.Tasks)
            //                .WithMany(t => t.UserTasks)
            //                .HasForeignKey(ut => ut.TaskId);

            //            // User-Comment (One-to-Many) Configuration
            //            modelBuilder.Entity<User>()
            //                .HasMany(u => u.Comments)
            //                .WithOne(c => c.User)
            //                .HasForeignKey(c => c.UserId)
            //                .OnDelete(DeleteBehavior.Cascade);
            //=======


            //            modelBuilder.Entity<Project>()
            //            .ToTable("ProjectF");

            //            modelBuilder.Entity<User>()
            //            .HasOne(u => u.Attachment)          // E
            //            .WithOne(a => a.User)               
            //            .HasForeignKey<User>(u => u.AttachmentId) 
            //            .OnDelete(DeleteBehavior.Cascade);



            //            modelBuilder.Entity<Project>().HasOne<User>(u=>u.User)
            //                .WithMany(u => u.Projects).HasForeignKey(p => p.userID);



            //            modelBuilder.Entity<User>().HasMany(u => u.ProjectUsers)
            //                .WithOne(p => p.User).HasForeignKey(p => p.userId).OnDelete(DeleteBehavior.Cascade);

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

            //            // Agile-Sprint (One-to-Many) Configuration
            //            modelBuilder.Entity<Agile>()
            //                .HasMany(a => a.Sprints)
            //                .WithOne(s => s.Agile)
            //                .HasForeignKey(s => s.AgileId)
            //                .OnDelete(DeleteBehavior.Cascade);

            // Agile-Sprint (One-to-Many) Configuration
            modelBuilder.Entity<Agile>()
            .HasMany(u => u.Sprints)    // A User has many Tasks
            .WithOne(t => t.Agile)    // Each Task has one User
            .HasForeignKey(t => t.AgileId)  // Foreign key in Task table
            .OnDelete(DeleteBehavior.Cascade);

            //            // Waterfall-Task (One-to-Many) Configuration
            //            modelBuilder.Entity<Waterfall>()
            //                .HasMany(w => w.Tasks)
            //                .WithOne(t => t.Waterfall)
            //                .HasForeignKey(t => t.WaterfallId)
            //                .OnDelete(DeleteBehavior.Cascade);
            //=======
            //            /////


            //            // modelBuilder.Entity<User>()
            //            // .HasMany(t => t.Waterfalls)    // A Task has many Comments
            //            // .WithOne(c => c.User)       // Each Comment has one Task
            //            // .HasForeignKey(c => c.userId)  // Foreign key in Comment table
            //            // .OnDelete(DeleteBehavior.Cascade);

            //        //    modelBuilder.Entity<Waterfall>().HasOne<User>(u => u.User)
            //           //     .WithMany(u => u.Waterfalls).HasForeignKey(u=> u.userId);
            //           //
            //            modelBuilder.Entity<Waterfall>()
            //            .HasMany(u => u.Tasks)    // A User has many Tasks
            //            .WithOne(t => t.Waterfall)    // Each Task has one User
            //            .HasForeignKey(t => t.ProjectId)  // Foreign key in Task table
            //            .OnDelete(DeleteBehavior.Cascade);

            //            modelBuilder.Entity<User>().HasMany(u => u.UserTasks)
            //                .WithOne(c => c.User)
            //                .HasForeignKey(t => t.userID);

            //            modelBuilder.Entity<Task>().HasMany(u => u.UserTasks)
            //                .WithOne(c => c.Task)
            //                .HasForeignKey(t => t.TaskID);


            //>>>>>>> b14d04820704608e9f3058714677eb101c5d41b0
        }

        // DbSets for the 10 Models
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<ProjectUser> ProjectUsers { get; set; }
        public DbSet<Agile> Agiles { get; set; }
        public DbSet<Waterfall> Waterfalls { get; set; }
        public DbSet<Sprint> Sprints { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserTask> UserTasks { get; set; }
    }
}