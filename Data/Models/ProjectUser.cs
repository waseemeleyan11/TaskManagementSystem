using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Data.Models
{
    public class ProjectUser
    {
        
        [ForeignKey("User")]
        public int DeveloperId { get; set; }
        public User Developer { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}