using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Data.Models;
using Task = TaskManagementSystem.Data.Models.Task;


namespace TaskManagementSystem.Data
{
    using TaskManagementSystem.Data.Models;

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

            modelBuilder.Entity<Agile>()
            .ToTable("Agiles");

            modelBuilder.Entity<Waterfall>()
                .ToTable("Waterfalls");

                // modelBuilder.Entity<Project>()
              //   .ToTable("ProjectF");

                 modelBuilder.Entity<User>()
                 .HasOne(u => u.Attachment)          // E
                 .WithOne(a => a.User)               
                 .HasForeignKey<User>(u => u.AttachmentId) 
                 .OnDelete(DeleteBehavior.Cascade);


            
         modelBuilder.Entity<Project>().HasOne<User>(u=>u.User)
           .WithMany(u => u.Projects).HasForeignKey(p => p.userID).OnDelete(DeleteBehavior.Restrict);
           

       

           modelBuilder.Entity<User>().HasMany(u => u.ProjectUsers)
               .WithOne(p => p.).HasForeignKey(p => p.userId).OnDelete(DeleteBehavior.Cascade);
       
            modelBuilder.Entity<ProjectUser>().HasKey(a => new { a.userId, a.projectId });

            modelBuilder.Entity<UserTask>().HasKey(a => new { a.userID,a.TaskID });
              

            modelBuilder.Entity<Project>().HasMany(u => u.ProjectUsers)
                 .WithOne(p => p.Project).HasForeignKey(p => p.projectId);

            modelBuilder.Entity<User>()
             .HasMany(u => u.Sprints)
             .WithOne(c => c.User)       
             .HasForeignKey(c => c.UserId)  
             .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Project>()
                .HasOne(u => u.Attachment)
                .WithOne(a => a.Project).HasForeignKey<Project>(a=>a.attachmentId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Task>()
               .HasOne(u => u.Attachment)
               .WithOne(a => a.Task).HasForeignKey<Task>(a => a.AttachmentId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>()
              .HasMany(u => u.Comments)
              .WithOne(c => c.User)       
              .HasForeignKey(c => c.UserId)   
              .OnDelete(DeleteBehavior.Cascade);
                .HasMany(u => u.Comments)
                .WithOne(c => c.User)
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
              .HasMany(u => u.Tasks)   
              .WithOne(t => t.User)   
              .HasForeignKey(t => t.UserId)  
              .OnDelete(DeleteBehavior.NoAction);

            

              

              

              modelBuilder.Entity<Task>()
             .HasMany(t => t.Comments)    // A Task has many Comments
             .WithOne(c => c.Task)       // Each Comment has one Task
             .HasForeignKey(c => c.TaskId)  // Foreign key in Comment table
             .OnDelete(DeleteBehavior.Cascade);
            // Task-Comment (One-to-Many) Configuration
            modelBuilder.Entity<Task>()
                .HasMany(t => t.Comments)
                .WithOne(c => c.Task)
                .HasForeignKey(c => c.TaskId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Agile>()
              .HasMany(u => u.Sprints)    // A User has many Tasks
              .WithOne(t => t.Agile)    // Each Task has one User
              .HasForeignKey(t => t.AgileId)  // Foreign key in Task table
              .OnDelete(DeleteBehavior.NoAction);

            
            /*

              
            // User-Sprint (One-to-Many) Configuration
            modelBuilder.Entity<User>()
           .HasMany(u => u.Sprints)
           .WithOne(c => c.User)       // Each Comment has one User
           .HasForeignKey(c => c.UserId)  // Foreign key in Comment table
           .OnDelete(DeleteBehavior.Cascade);

          //    modelBuilder.Entity<User>()
           //  .HasMany(t => t.Agiles)    // A Task has many Comments
            // .WithOne(c => c.User)       // Each Comment has one Task
            // .HasForeignKey(c => c.userId)  // Foreign key in Comment table
            // .OnDelete(DeleteBehavior.Cascade);

              
            // Agile-Sprint (One-to-Many) Configuration
            modelBuilder.Entity<Agile>()
            .HasMany(u => u.Sprints)    // A User has many Tasks
            .WithOne(t => t.Agile)    // Each Task has one User
            .HasForeignKey(t => t.AgileId)  // Foreign key in Task table
            .OnDelete(DeleteBehavior.Cascade);

              /////


              // modelBuilder.Entity<User>()
              // .HasMany(t => t.Waterfalls)    // A Task has many Comments
              // .WithOne(c => c.User)       // Each Comment has one Task
              // .HasForeignKey(c => c.userId)  // Foreign key in Comment table
              // .OnDelete(DeleteBehavior.Cascade);

          //    modelBuilder.Entity<Waterfall>().HasOne<User>(u => u.User)
             //     .WithMany(u => u.Waterfalls).HasForeignKey(u=> u.userId);

              modelBuilder.Entity<Waterfall>()
              .HasMany(u => u.Tasks)    // A User has many Tasks
              .WithOne(t => t.Waterfall)    // Each Task has one User
              .HasForeignKey(t => t.ProjectId)  // Foreign key in Task table
              .OnDelete(DeleteBehavior.Cascade);
            */

            modelBuilder.Entity<Sprint>()
              .HasMany(u => u.Tasks)    // A User has many Tasks
              .WithOne(t => t.Sprint)    // Each Task has one User
              .HasForeignKey(t => t.SprintId)  // Foreign key in Task table
              .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<User>().HasMany(u => u.UserTasks)
                  .WithOne(c => c.User)
                  .HasForeignKey(t => t.userID).OnDelete(DeleteBehavior.SetNull);

              modelBuilder.Entity<Task>().HasMany(u => u.UserTasks)
                  .WithOne(c => c.Task)
                  .HasForeignKey(t => t.TaskID).OnDelete(DeleteBehavior.SetNull);
         

            base.OnModelCreating(modelBuilder);

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