using System.ComponentModel.DataAnnotations;

namespace VersionControlSystem.Models
{
    public enum PullRequestStatus
    {
        Open,
        Accepted,
        Rejected
    }

    public class PullRequest
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        public string Description { get; set; }

        public PullRequestStatus Status { get; set; } = PullRequestStatus.Open;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Релации
        [Required]
        public int SourceRepositoryId { get; set; }
        public Repository SourceRepository { get; set; }

        [Required]
        public int TargetRepositoryId { get; set; }
        public Repository TargetRepository { get; set; }

        [Required]
        public int AuthorId { get; set; }
        public User Author { get; set; }

        public ICollection<Commit> Commits { get; set; } = new List<Commit>();
    }
}