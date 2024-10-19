namespace VersionControlSystem.Models
{
    public class RepositoryUser
    {
        public int RepositoryId { get; set; }
        public Repository Repository { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}