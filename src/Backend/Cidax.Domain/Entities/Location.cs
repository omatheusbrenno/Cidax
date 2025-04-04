using Cidax.Domain.Enums;
using NetTopologySuite.Geometries;

namespace Cidax.Domain.Entities
{
    public class Location
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category Category { get; set; }
        public required Point Point { get; set; }
        public static Location Create(string name, Category category, double longitude, double latitude)
        {
            return new Location
            {
                Name = name,
                Category = category,
                Point = new Point(longitude, latitude) { SRID = 4326 }
            };
        }
    }
}
