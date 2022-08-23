using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.DTOs.User
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }

    }
}
