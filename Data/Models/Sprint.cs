using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Data.Models
{
    public class Sprint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public bool IsDeleted { get; set; }

        public int? AgileId { get; set; }
        public Agile Agile { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }



    }
}
