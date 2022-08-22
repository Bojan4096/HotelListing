

using HotelListing.API.Contracts;
using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Repository
{
    public class CountriesRepository : GenericRepository<Country>, ICountriesRepository
    {

        private readonly HotelListingDbContext _dbcontext;
        public CountriesRepository(HotelListingDbContext context) : base(context)
        {
            this._dbcontext = context;
        }

        public async Task<Country> GetDetails(int id)
        {
            return await _dbcontext.Countries.Include(data => data.hotels).FirstOrDefaultAsync(result => result.id == id); 
        }
    }
}
