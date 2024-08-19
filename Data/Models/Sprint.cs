using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Data.Models
{
    public class Sprint
    {
        [Key]
        [Required]
        public int id { get; set; }
        [StringLength(256)]
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        [StringLength(256)]
        public string status { get; set; }
        [DefaultValue(false)]
        public bool isDeleted { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        
        public Agile Agile { get; set; }
        public int AgileId { get; set; }

        public ICollection<Task> Tasks { get; set; }



    }
}
