using System;
using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class Flight
    {
        public int FlightId { get; set; }

        public int AirlineId { get; set; }
        public Airline? Airline { get; set; }

        public int AircraftId { get; set; }
        public Aircraft? Aircraft { get; set; }

        public int GateId { get; set; }
        public Gate? Gate { get; set; }

        public int OriginAirportId { get; set; }
        public Airport? OriginAirport { get; set; }

        public int DestinationAirportId { get; set; }
        public Airport? DestinationAirport { get; set; }

        public string FlightNumber { get; set; } = string.Empty;
        public DateTime DepartureDatetime { get; set; }
        public DateTime ArrivalDatetime { get; set; }
        public string Comment { get; set; } = string.Empty;

        public ICollection<FlightStatusChange> StatusChanges { get; set; } = new List<FlightStatusChange>();
        public ICollection<FlightRegistration> Registrations { get; set; } = new List<FlightRegistration>();
    }
}