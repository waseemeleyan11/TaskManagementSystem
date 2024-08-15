namespace TaskManagementSystem.Models
{
    public class Attachment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string PhysicalPath { get; set; }
        public string Type { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
        public bool IsDeleted { get; set; }

        public User User { get; set; } 
        public Task Task { get; set; }
        public Project Project { get; set; }

    }
}

