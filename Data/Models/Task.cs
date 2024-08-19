using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Xml.Linq;


namespace TaskManagementSystem.Data.Models
{
    public class Task
    {
        [Key ]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }   
        public string Status { get; set; }
        public string DescriptionAttagement { get; set; }
        public int priority { get; set; }
        public int SprintId { get; set; }
        public Sprint Sprint { get; set; }

        [ForeignKey(nameof(Project))]
        public int ProjectId { get; set; }
       // public Project Project { get; set; }
        public Waterfall Waterfall { get; set; }
        public Project Project { get; set; }
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }
        [ForeignKey(nameof(Attachments))]
        public int AttachmentId { get; set; }
        public Attachment Attachments { get; set; }
        

        public Attachments Attachments { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<UserTask> UserTasks { get; set; }

    }
}
