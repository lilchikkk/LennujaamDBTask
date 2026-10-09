using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class AircraftSize
    {
        public int AircraftSizeId { get; set; }
        public string SizeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<Aircraft> Aircrafts { get; set; } = new List<Aircraft>();
        public ICollection<Gate> Gates { get; set; } = new List<Gate>();
    }
}