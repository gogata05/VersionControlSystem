using System.ComponentModel.DataAnnotations;

namespace VersionControlSystem.Models
{
    public enum ModificationType
    {
        Added,
        Modified,
        Deleted
    }

    public class Modification
    {
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        public string FileDifferences { get; set; } // Съхранява разликите като текст

        public ModificationType ModificationType { get; set; }

        // Релации
        public int CommitId { get; set; }
        public Commit Commit { get; set; }
    }
}