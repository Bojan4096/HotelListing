using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    id = 1,
                    name = "Serbia",
                    countryCode = "SRB"
                },
                new Country
                {
                    id = 2,
                    name = "Croatia",
                    countryCode = "CRO"
                },
                new Country
                {
                    id = 3,
                    name = "Germany",
                    countryCode = "GER"
                },
                new Country
                {
                    id = 4,
                    name = "United States of America",
                    countryCode = "USA"
                },
                new Country
                {
                    id = 5,
                    name = "China",
                    countryCode = "CNY"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    id = 1,
                    name = "Hotel Sajam",
                    address = "Novi Sad",
                    countryId = 1,
                    rating = 4.1,
                },
                new Hotel
                {
                    id = 2,
                    name = "Hotel Moskva",
                    address = "Beograd",
                    countryId = 1,
                    rating = 5,
                },
                new Hotel
                {
                    id = 3,
                    name = "Hotel Dubrovnik",
                    address = "Dubrovnik",
                    countryId = 2,
                    rating = 4.2,
                },
                new Hotel
                {
                    id = 4,
                    name = "Weisehotel",
                    address = "Frankfurt",
                    countryId = 3,
                    rating = 5,
                },
                new Hotel
                {
                    id = 5,
                    name = "Bestwestern",
                    address = "Fairbanks",
                    countryId = 4,
                    rating = 4.1,
                },
                new Hotel
                {
                    id = 6,
                    name = "Riverside hotel",
                    address = "Guilin",
                    countryId = 5,
                    rating = 3.8,
                }

            );
        }
    }
}
