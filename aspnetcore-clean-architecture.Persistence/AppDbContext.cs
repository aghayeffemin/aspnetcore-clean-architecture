using aspnetcore_clean_architecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_clean_architecture.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                 new User
                 {
                     Id = Guid.NewGuid(),
                     Name = "John",
                     Surname = "Doe",
                     DateCreated = DateTime.Now,
                     DateModified = DateTime.Now,
                 }
            );
        }
    }
}
