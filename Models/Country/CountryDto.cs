public class CountryDto : BaseCountryDto
{
    public int Id { get; set; }
    
    public virtual List<HotelDto> Hotels { get; set; }
}