using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Channel> Channels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Channel>()
            .HasData(new Channel{
                id = Guid.NewGuid(),
                Name = "DotNetCore",
                Description = "Canal dedicado a dotnetcore"
            },
            new Channel{
                id = Guid.NewGuid(),
                Name = "Angular",
                Description = "Canal dedicado a Angular"
            },
            new Channel{
                id = Guid.NewGuid(),
                Name = "ReactJs",
                Description = "Canal dedicado a ReactJs"
            });
        }
    }
}