using HotelListing.API.Data;
using HotelListing.API.DTOs.Hotel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.DTOs.Country
{
    public class GetCountryDto: BaseCountryDto
    {
        public int id { get; set; }

    }
}
