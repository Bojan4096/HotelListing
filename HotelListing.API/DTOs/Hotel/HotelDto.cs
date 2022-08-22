namespace HotelListing.API.DTOs.Hotel
{
    public class HotelDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public double rating { get; set; }
        public int countryId { get; set; }

    }
}
