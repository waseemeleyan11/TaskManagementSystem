using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace Project.Data.Model
{
    public class Project
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public DateTime expectedDateToStart { get; set; }
        [Required,StringLength(128)]
        public string status { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool flag { get; set; }
        [StringLength(256)]
        public string link { get; set; }
        [DefaultValue(false)]
        public bool isDeleted { get; set; }
        public User User { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public int userId { get; set; }
        public ICollection<ProjectUser> projectUsers { get; set; }
        public Attachment Attachment { get; set; }
        [Required]
        [ForeignKey(nameof(Attachment))]
        public int attachmentId { get; set; }



    }
}
