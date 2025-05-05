using NetTopologySuite.Geometries;

namespace GeoLocations.Domain.Entities;

public class Location
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public Category Category { get; set; }
    public Point Coordinates { get; set; } = default!;
}