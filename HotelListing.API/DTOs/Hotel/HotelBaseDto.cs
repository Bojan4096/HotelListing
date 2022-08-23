using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.Hotel
{
    public abstract class HotelBaseDto
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string address { get; set; }
        public double? rating { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int countryId { get; set; }
    }
}
