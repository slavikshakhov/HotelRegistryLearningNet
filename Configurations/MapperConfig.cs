using AutoMapper;

public class MapperConfig : Profile
{
    public MapperConfig()
    {
        CreateMap<Country, CreateCountryDto>().ReverseMap();
        CreateMap<Country, GetCountryDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<Country, UpdateCountryDto>().ReverseMap();

        CreateMap<Hotel, CreateHotelDto>().ReverseMap();
        CreateMap<Hotel, HotelDto>().ReverseMap();
       
    }
}