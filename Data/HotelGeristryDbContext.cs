using Microsoft.EntityFrameworkCore;

public class HotelGeristryDbContext : DbContext
{
    public HotelGeristryDbContext(DbContextOptions<HotelGeristryDbContext> options) : base(options)
    {

    }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Country> Countries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Country>().HasData(
            new Country
            {
                Id = 1,
                Name = "Jamaica",
                ShortName = "JM"
            }
        );
        modelBuilder.Entity<Hotel>().HasData(
            new Hotel
            {
                Id = 1,
                Name = "My Hotel",
                Address = "Negril",
                Rating = 4.5,
                CountryId = 1
            },
             new Hotel
             {
                 Id = 2,
                 Name = "My Hotel2",
                 Address = "some address",
                 Rating = 5.0,
                 CountryId = 1
             }
        );
    }
}