using System;
using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class FlightRegistration
    {
        public int FlightRegistrationId { get; set; }

        public int PassengerId { get; set; }
        public Passenger? Passenger { get; set; }

        public int FlightId { get; set; }
        public Flight? Flight { get; set; }

        public int TicketTypeId { get; set; }
        public TicketType? TicketType { get; set; }

        public string SeatNumber { get; set; } = string.Empty;
        public DateTime RegistrationTime { get; set; }
        public string Comment { get; set; } = string.Empty;

        public ICollection<Baggage> Baggages { get; set; } = new List<Baggage>();
    }
}