using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("[controller]")]
public class TestDbController : ControllerBase
{
    private readonly HotelGeristryDbContext _context;

    public TestDbController(HotelGeristryDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult CheckConnection()
    {
        try
        {
            // Just try to query something (even if empty)
            var dbExists = _context.Database.CanConnect();
            return Ok(new { success = dbExists });
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { error = ex.Message });
        }
    }
}