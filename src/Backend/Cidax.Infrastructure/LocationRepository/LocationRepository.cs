using Cidax.Domain.Entities;
using Cidax.Domain.Repositories;
using Cidax.Infrastructure.Context;
using System.Threading.Tasks;

namespace Cidax.Infrastructure.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly CidaxDbContext _context;

        public LocationRepository(CidaxDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Location location)
        {
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
        }
    }
}
