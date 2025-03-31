using Cidax.Domain.Enums;
using System.Drawing;

namespace Cidax.Domain.Entities
{
    public class Location
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Category? Category { get; set; }
        public Point Point { get; set; }
    }
}
