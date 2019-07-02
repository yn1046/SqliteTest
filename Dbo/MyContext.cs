using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Dbo
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=blogging.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Vovan666",
                    IsAdmin = true,
                    Bio = "I'm a cool guy"
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Sanek1999",
                    IsAdmin = false,
                    Bio = "Swagg..."
                });
        }
    }
}