using GeoLocations.Application.DTOs;

namespace GeoLocations.Application.Interfaces;

public interface ILocationService
{
    Task<IEnumerable<LocationDto>> GetAllAsync();
    Task<LocationDto?> GetByIdAsync(Guid id);
    Task<LocationDto> CreateAsync(CreateLocationRequest request);
    Task<LocationDto?> UpdateAsync(Guid id, CreateLocationRequest request);
    Task<bool> DeleteAsync(Guid id);
    Task<string> GetGeoJsonAsync();
}
