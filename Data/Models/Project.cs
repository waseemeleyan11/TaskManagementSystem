using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace TaskManagementSystem.Data.Models
{
    //SamaComment
    public class Project
    {
        [Key]
        public int projectId { get; set; }
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
        public int userID { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }

        
        public Attachment Attachment { get; set; }

        [Required]
        public int attachmentId { get; set; }




    }
}
