using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Data.Models
{
    public class ProjectUser
    {
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public User User { get; set; }
        public int userId { get; set; }
    }
}