using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VersionControlSystem.Models
{
    public class Repository
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } // For search index

        public bool IsPublic { get; set; }

        public int OwnerId { get; set; }

        [JsonIgnore] // Prevent serialization and model binding
        public User Owner { get; set; }

        public ICollection<RepositoryUser> Contributors { get; set; } = new List<RepositoryUser>();
        public ICollection<Commit> Commits { get; set; } = new List<Commit>();
        public ICollection<Issue> Issues { get; set; } = new List<Issue>();
        public ICollection<PullRequest> PullRequests { get; set; } = new List<PullRequest>();

        // Нови навигационни свойства за PullRequests
        public ICollection<PullRequest> SourcePullRequests { get; set; } = new List<PullRequest>();
        public ICollection<PullRequest> TargetPullRequests { get; set; } = new List<PullRequest>();
    }
}