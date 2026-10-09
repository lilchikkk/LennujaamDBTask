using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class TicketType
    {
        public int TicketTypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<FlightRegistration> Registrations { get; set; } = new List<FlightRegistration>();
    }
}