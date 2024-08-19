using System.ComponentModel.DataAnnotations;
//19/8

namespace TaskManagementSystem.Data.Models
{
    public class Attachment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string PhysicalPath { get; set; }
        public string Type { get; set; }
        public bool IsDeleted { get; set; }

        // Relationships
        public User User { get; set; }
        public Project Project { get; set; }
        public Task Task { get; set; }
    }
}
