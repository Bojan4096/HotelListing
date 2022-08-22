using HotelListing.API.Data;
using HotelListing.API.DTOs.Hotel;

namespace HotelListing.API.DTOs.Country
{
    public class CountryDto : BaseCountryDto
    {
        public int id { get; set; }
        public List<HotelDto> hotels { get; set; }
    }
}
