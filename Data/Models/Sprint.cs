using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Data.Models
{
    public class Sprint
    {
        [Key]
        public int id { get; set; }
        [StringLength(256)]
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        [StringLength(256)]
        public string status { get; set; }
        [DefaultValue(false)]
        public bool isDeleted { get; set; }
        
        
        public Agile Agile { get; set; }
        public int AgileId { get; set; }
       

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<Task>  Tasks { get; set; }



    }
}
