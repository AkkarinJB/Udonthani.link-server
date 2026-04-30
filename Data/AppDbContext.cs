using Microsoft.EntityFrameworkCore;
using udonthani_link_api.Models;

namespace udonthani_link_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Location> Locations { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobType> JobTypes { get; set; }

        public DbSet<Company> Companies { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }

        public DbSet<JobSeeker> JobSeekers { get; set; }
        public DbSet<Application> Applications { get; set; }

        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();
        }
    }
}