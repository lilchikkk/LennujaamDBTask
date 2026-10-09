using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class Gate
    {
        public int GateId { get; set; }
        public int TerminalId { get; set; }
        public Terminal? Terminal { get; set; }

        public int MaxAircraftSizeId { get; set; }
        public AircraftSize? MaxAircraftSize { get; set; }

        public string GateNumber { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
}