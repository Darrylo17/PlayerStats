using Microsoft.EntityFrameworkCore;

namespace PlayerStatsProject.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options)
            : base(options)
        {
        }

        public DbSet<Players> Players { get; set; } = null!;
    }
}