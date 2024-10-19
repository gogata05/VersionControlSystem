using System.ComponentModel.DataAnnotations;

namespace VersionControlSystem.Models
{
    public enum IssueStatus
    {
        Open,
        OnHold,
        Closed
    }

    public class Issue
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        public string Tags { get; set; }

        public IssueStatus Status { get; set; } = IssueStatus.Open;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int RepositoryId { get; set; }
        public Repository Repository { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}