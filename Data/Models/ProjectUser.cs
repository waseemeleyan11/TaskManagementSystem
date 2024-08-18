using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Data.Models
{
    public class ProjectUser
    {
        
        public Project Project { get; set; }
        [ForeignKey(nameof(Project))]
        public int projectId { get; set; }
        public User User { get; set; }
        [ForeignKey(nameof(User))]
        public int userId { get; set; }
        [Required]
        [MaxLength(100)]
        public string type { get; set; }
    }
}
