using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelsRepository : GenericRepository<Hotel>, IHotelsRepository
    {
        private readonly HotelListingDbContext _dbcontext;
        public HotelsRepository(HotelListingDbContext context) : base(context)
        {
            this._dbcontext = context;
        }
    }
}
