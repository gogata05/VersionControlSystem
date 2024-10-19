using System.ComponentModel.DataAnnotations;

namespace VersionControlSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public ICollection<Repository> OwnedRepositories { get; set; } = new List<Repository>();
        public ICollection<RepositoryUser> RepositoryContributions { get; set; } = new List<RepositoryUser>();
        public ICollection<Commit> Commits { get; set; } = new List<Commit>();
        public ICollection<Issue> Issues { get; set; } = new List<Issue>();
    }
}