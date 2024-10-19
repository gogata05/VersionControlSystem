using Microsoft.EntityFrameworkCore;

namespace VersionControlSystem.Models.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Repository> Repositories { get; set; }
        public DbSet<RepositoryUser> RepositoryUsers { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Commit> Commits { get; set; }
        public DbSet<Modification> Modifications { get; set; }
        public DbSet<PullRequest> PullRequests { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RepositoryUser>()
                .HasKey(ru => new { ru.RepositoryId, ru.UserId });

            modelBuilder.Entity<RepositoryUser>()
                .HasOne(ru => ru.Repository)
                .WithMany(r => r.Contributors)
                .HasForeignKey(ru => ru.RepositoryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<RepositoryUser>()
                .HasOne(ru => ru.User)
                .WithMany(u => u.RepositoryContributions)
                .HasForeignKey(ru => ru.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Username)
                .IsUnique();

            modelBuilder.Entity<Repository>()
                .HasIndex(r => r.Title);

            modelBuilder.Entity<Issue>()
                .HasIndex(i => i.CreatedAt);

            modelBuilder.Entity<Commit>()
                .HasIndex(c => c.CreatedAt);

            modelBuilder.Entity<PullRequest>()
                .HasIndex(pr => pr.CreatedAt);

            modelBuilder.Entity<PullRequest>()
                .HasOne(pr => pr.SourceRepository)
                .WithMany(r => r.SourcePullRequests)
                .HasForeignKey(pr => pr.SourceRepositoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PullRequest>()
                .HasOne(pr => pr.TargetRepository)
                .WithMany(r => r.TargetPullRequests)
                .HasForeignKey(pr => pr.TargetRepositoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Issue>()
                .HasOne(i => i.Author)
                .WithMany(u => u.Issues)
                .HasForeignKey(i => i.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Repository>()
                .HasOne(r => r.Owner)
                .WithMany(u => u.OwnedRepositories)
                .HasForeignKey(r => r.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Commit>()
                .HasOne(c => c.Author)
                .WithMany(u => u.Commits)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "defaultuser",
                Password = "password123"
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
