using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Data.Model
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
        public Agile Agile { get; set; }
        [ForeignKey(nameof(Agile))]
        public int AgileId { get; set; }
        public ICollection<Task> Tasks { get; set; }



    }
}
