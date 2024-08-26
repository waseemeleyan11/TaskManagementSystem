using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.DTO
{
    public class AttachmentDTO
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string PhysicalPath { get; set; }
        public string Type { get; set; }
        public bool IsDeleted { get; set; }
    }
}
