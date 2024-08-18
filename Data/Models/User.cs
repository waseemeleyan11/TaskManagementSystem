using TaskManagementSystem.Data.Models;

namespace TaskManagementSystem.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public DateTime DateRegistration { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsDeleted { get; set; }
        //AnotherTest
        public int? AttachmentId { get; set; }
        //Test
        public Attachment Attachment { get; set; }
        public Project Project { get; set; }
        public UserTask UserTask { get; set; }
        public Waterfall Waterfall { get; set; }
      //  public Task Task { get; set; }
        //public Sprint Sprint { get; set; }
        public Agile Agile { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public ICollection<Sprint> Sprints { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }



    }

}