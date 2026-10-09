using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class BaggageType
    {
        public int BaggageTypeId { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<Baggage> Baggages { get; set; } = new List<Baggage>();
    }
}