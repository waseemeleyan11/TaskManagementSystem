﻿using Microsoft.EntityFrameworkCore;
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
            .HasKey(pu => new { pu.DeveloperId, pu.ProjectId });

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.Developer)
                .WithMany(u => u.ProjectUsers)
                .HasForeignKey(pu => pu.DeveloperId);

            modelBuilder.Entity<ProjectUser>()
                .HasOne(pu => pu.Project)
                .WithMany(p => p.ProjectUsers)
                .HasForeignKey(pu => pu.ProjectId);

            // UserTask relationships
            modelBuilder.Entity<UserTask>()
            .HasKey(ut => new { ut.DeveloperId, ut.TaskId });

            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.Developer)
                .WithMany(u => u.UserTasks)
                .HasForeignKey(ut => ut.DeveloperId);

            modelBuilder.Entity<UserTask>()
                .HasOne(ut => ut.Task)
                .WithMany(t => t.UserTasks)
                .HasForeignKey(ut => ut.TaskId);

            // Project relationships
            modelBuilder.Entity<Project>()
                .HasOne(p => p.CreatedBy)
                .WithMany(u => u.CreatedProjects)
                .HasForeignKey(p => p.CreatedById);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.AddedAttachment)
                .WithOne(a => a.Project)
                .HasForeignKey<Project>(p => p.AddedAttachmentId);

            // Agile relationships
            modelBuilder.Entity<Agile>()
                .HasMany(a => a.Sprints)
                .WithOne(s => s.Agile)
                .HasForeignKey(s => s.AgileId);

            // Waterfall relationships
            modelBuilder.Entity<Waterfall>()
                .HasMany(w => w.Tasks)
                .WithOne(t => t.Waterfall)
                .HasForeignKey(t => t.WaterfallId);

            // Sprint relationships
            modelBuilder.Entity<Sprint>()
                .HasOne(s => s.CreatedBy)
                .WithMany(u => u.CreatedSprints)
                .HasForeignKey(s => s.CreatedById);

            modelBuilder.Entity<Sprint>()
                .HasMany(s => s.Tasks)
                .WithOne(t => t.Sprint)
                .HasForeignKey(t => t.SprintId);

            // Task relationships
            modelBuilder.Entity<Task>()
                .HasOne(t => t.Sprint)
                .WithMany(s => s.Tasks)
                .HasForeignKey(t => t.SprintId);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.Waterfall)
                .WithMany(w => w.Tasks)
                .HasForeignKey(t => t.WaterfallId);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.AddedAttachment)
                .WithOne(a => a.Task)
                .HasForeignKey<Task>(t => t.AddedAttachmentId);

            modelBuilder.Entity<Task>()
                .HasOne(t => t.CreatedBy)
                .WithMany(u => u.CreatedTasks)
                .HasForeignKey(t => t.CreatedById);

            modelBuilder.Entity<Task>()
                .HasMany(t => t.addedComments)
                .WithOne(c => c.Task)
                .HasForeignKey(c => c.TaskId);

            // Comment relationships
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.AddedBy)
                .WithMany(u => u.Comments)
                .HasForeignKey(c => c.AddedById);
            // Inheritance configuration
            modelBuilder.Entity<Agile>()
                .ToTable("AgileProjects");

            modelBuilder.Entity<Waterfall>()
                .ToTable("WaterfallProjects");

            base.OnModelCreating(modelBuilder);
        }
    }
}
