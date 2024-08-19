using System.ComponentModel.DataAnnotations;
using TaskManagementSystem.Data.Models;

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

        public int? AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
        //public Project Project { get; set; }
      //  public Task Task { get; set; }
        //public Sprint Sprint { get; set; }
        //public Agile Agile { get; set; }
        //public ICollection<Agile> Agiles { get; set; }

        //public ICollection<Waterfall> Waterfalls { get; set; }

        //public ICollection<Comment> Comments { get; set; }
        //public ICollection<Task> Tasks { get; set; }
        //public ICollection<Sprint> Sprints { get; set; }

        //public ICollection<Project> Projects { get; set; }
        //public ICollection<ProjectUser> ProjectUsers { get; set; }
        //public ICollection<UserTask> UserTasks { get; set; }





    }

}
