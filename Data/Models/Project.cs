using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
//19/8 v2

namespace TaskManagementSystem.Data.Models
{
    
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public DateTime ExpectedDateToStart { get; set; }
        [Required,StringLength(128)]
        public EnumProject Status { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool Flag { get; set; }
        [StringLength(256)]
        public string Link { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

        // Relationships
        public ICollection<ProjectUser> ProjectUsers { get; set; }




        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }

                [Required]
        public int? AddedAttachmentId { get; set; }
        public Attachment AddedAttachment { get; set; }
    }
}
