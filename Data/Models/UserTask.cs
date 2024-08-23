using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Data.Models
{
    public class UserTask
    {
        [ForeignKey("User")]
        public int DeveloperId { get; set; }
        public User Developer { get; set; }

        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public Task Task { get; set; }


    }
}
