using System;

namespace LennujaamDBTask.Models
{
    public class FlightStatusChange
    {
        public int FlightStatusChangeId { get; set; }

        public int FlightId { get; set; }
        public Flight? Flight { get; set; }

        public int FlightStatusId { get; set; }
        public FlightStatus? FlightStatus { get; set; }

        public DateTime ChangedAt { get; set; }
        public string Reason { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
    }
}