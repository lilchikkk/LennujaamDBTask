using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string IataCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<Flight> OriginFlights { get; set; } = new List<Flight>();
        public ICollection<Flight> DestinationFlights { get; set; } = new List<Flight>();
    }
}