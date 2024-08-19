using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//19/8

namespace TaskManagementSystem.Data.Models
{
    public class UserTask
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
