using TaskManagementSystem.Data.Models;
using Task = TaskManagementSystem.Data.Models.Task;

public class Comment
{
    public int CommentId { get; set; }
    public string CommentText { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }

    public int? UserId { get; set; }
    public User User { get; set; }

    public int? TaskId { get; set; }
    public Task Task { get; set; }
}