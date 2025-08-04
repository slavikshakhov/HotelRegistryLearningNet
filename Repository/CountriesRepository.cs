
using Microsoft.EntityFrameworkCore;

public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
{
    private readonly HotelGeristryDbContext _context;
    public CountriesRepository(HotelGeristryDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Country> GetDetails(int id)
    {
        return await _context.Countries.Include(q => q.Hotels).FirstOrDefaultAsync(q => q.Id == id);
    }
}