using System.Threading.Tasks;
using Cidax.Domain.Entities;

namespace Cidax.Domain.Repositories
{
    public interface ILocationRepository
    {
        Task AddAsync(Location location);
    }
}
