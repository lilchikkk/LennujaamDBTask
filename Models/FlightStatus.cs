using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class FlightStatus
    {
        public int FlightStatusId { get; set; }
        public string StatusName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<FlightStatusChange> StatusChanges { get; set; } = new List<FlightStatusChange>();
    }
}