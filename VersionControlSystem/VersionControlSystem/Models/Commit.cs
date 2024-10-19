using System.ComponentModel.DataAnnotations;

namespace VersionControlSystem.Models
{
    public class Commit
    {
        public int Id { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int RepositoryId { get; set; }
        public Repository Repository { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public ICollection<Modification> Modifications { get; set; } = new List<Modification>();
    }
}