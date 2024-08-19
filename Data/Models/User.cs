using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//19/8 v2

namespace TaskManagementSystem.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime DateRegistration { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsDeleted { get; set; }

        // Relationships
        public ICollection<Project> CreatedProjects { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }
        public ICollection<Sprint> CreatedSprints { get; set; }
        public Attachment ProfilePic { get; set; }
        public int? ProfilePicId { get; set; }
        public ICollection<Task> CreatedTasks { get; set; }
        public ICollection<UserTask> UserTasks { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
