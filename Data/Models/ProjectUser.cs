using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//19/8 v2

namespace TaskManagementSystem.Data.Models
{
    public class ProjectUser
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }
        public int userId { get; set; }
    }
}