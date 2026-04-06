using GITPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace GITPractice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Pritam", City = "Pune" },
                new User { Id = 2, Name = "Rahul", City = "Mumbai" }
            );
        }
    }
}
