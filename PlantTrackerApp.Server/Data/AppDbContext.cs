using Microsoft.EntityFrameworkCore;
using PlantTrackerApp.Server.Models;

namespace PlantTrackerApp.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Plant> Plants { get; set; } = null!;
    }
}
