using System.ComponentModel.DataAnnotations;

namespace VersionControlSystem.Models.Dtos
{
    public class CreateRepositoryDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public bool IsPublic { get; set; }
    }
}
