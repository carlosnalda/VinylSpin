using Microsoft.EntityFrameworkCore;

namespace VinylSpinService.Data
{
    public class VinylSpinContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; } = null!;
        public DbSet<Genre> Genres { get; set; } = null!;
        public DbSet<Vinyl> Vinyls { get; set; } = null!;

        public VinylSpinContext(DbContextOptions<VinylSpinContext> options)
            : base(options)
        {
        }
    }
}