namespace HotelListing.API.Data
{
    public class Country
    {
        public int id { get; set; }
        public string name { get; set; }
        public string countryCode { get; set; }

        public virtual IList<Hotel> hotels { get; set; }

    }
}