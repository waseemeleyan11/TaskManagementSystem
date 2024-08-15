using System.Xml.Linq;

namespace TaskManagementSystem.Models
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
        public int AttachmentId { get; set; }
        public Attachment Attachment { get; set; }
        public Project Project { get; set; }
        public ProjectUser ProjectUser { get; set; }
        public User_Task User_Task { get; set; }
        public Waterfall Waterfall { get; set; }
        public Task Task { get; set; }
        public Sprint Sprint { get; set; }
        public Agile Agile { get; set; }
        public Comment Comment { get; set; }











    }


}
