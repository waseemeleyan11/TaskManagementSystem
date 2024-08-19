using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//19/8

namespace TaskManagementSystem.Data.Models
{
    public class ProjectUser
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
