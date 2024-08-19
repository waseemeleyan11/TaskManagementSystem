using TaskManagementSystem.Data.Models;

namespace TaskManagementSystem.Data.Models
{
    public class UserTask
    {
        public User User { get; set; }
        public int userID { get; set; }
        public Task Task { get; set; }
        public int TaskID { get; set; }


    }
}
