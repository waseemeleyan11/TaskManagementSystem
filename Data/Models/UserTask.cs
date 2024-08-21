using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//19/8 v2

namespace TaskManagementSystem.Data.Models
{
    public class UserTask
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
