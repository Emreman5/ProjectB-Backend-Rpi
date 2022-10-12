using Microsoft.EntityFrameworkCore;
using RpiServerAPI.Models;

namespace RpiServerAPI.DataAccess;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;
    public DbSet<MapData> Maps { get; set; }
    public DbSet<Beacon> Beacons { get; set; }

    public DataContext(IConfiguration configuration, DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        Configuration = configuration;
    }

    public DataContext()
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Beacon[] beaconSeeds = new[]
        {
            new Beacon()
            {
                Id = 1,
                Uuid = "dadadada",
                LocationX = 200,
                LocationY = 300,
                MapId = 3,
                Status = true,
                
            }
        };
        modelBuilder.Entity<Beacon>().HasData(beaconSeeds);
    }
}
   