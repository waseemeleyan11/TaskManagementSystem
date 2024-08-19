using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using System.Xml.Linq;


namespace TaskManagementSystem.Data.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public string DescriptionAttachment { get; set; }
        public string Priority { get; set; }
        public bool IsDeleted { get; set; }

        public int? WaterfallId { get; set; }
        public Waterfall Waterfall { get; set; }

        public ICollection<UserTask> UserTasks { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
