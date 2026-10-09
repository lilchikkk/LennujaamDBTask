using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class Aircraft
    {
        public int AircraftId { get; set; }
        public int AircraftSizeId { get; set; }
        public AircraftSize? AircraftSize { get; set; }

        public string RegistrationNumber { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int SeatCount { get; set; }
        public int ManufactureYear { get; set; }
        public string Comment { get; set; } = string.Empty;

        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
}