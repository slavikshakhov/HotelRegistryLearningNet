public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
{
    private readonly HotelGeristryDbContext _context;
    public HotelsRepository(HotelGeristryDbContext context) : base(context)
    {
        _context = context;
    }
}