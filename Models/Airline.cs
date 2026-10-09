using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class Airline
    {
        public int AirlineId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<Flight> Flights { get; set; } = new List<Flight>();
    }
}