using Microsoft.Build.Framework;

namespace HotelListing.API.Data
{
    public abstract class BaseCountryDto
    {
        public string name { get; set; }
        public string countryCode { get; set; }
    }
}
