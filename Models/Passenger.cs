using System;
using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string DocumentNumber { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<FlightRegistration> Registrations { get; set; } = new List<FlightRegistration>();
    }
}