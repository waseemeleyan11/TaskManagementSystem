using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
//19/8 v2

namespace TaskManagementSystem.Data.Models
{
    //SamaComment
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public DateTime ExpectedDateToStart { get; set; }
        [Required,StringLength(128)]
        public string Status { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool Flag { get; set; }
        [StringLength(256)]
        public string Link { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        // Relationships
        public int UserId { get; set; }
        [AllowNull]
        public User User { get; set; }
        public ICollection<ProjectUser> ProjectUsers { get; set; }

        
        public Attachment Attachment { get; set; }

        [Required]
        public int? AttachmentId { get; set; }




    }
}
