namespace LennujaamDBTask.Models
{
    public class Baggage
    {
        public int BaggageId { get; set; }

        public int FlightRegistrationId { get; set; }
        public FlightRegistration? FlightRegistration { get; set; }

        public int BaggageTypeId { get; set; }
        public BaggageType? BaggageType { get; set; }

        public string TagNumber { get; set; } = string.Empty;
        public decimal WeightKg { get; set; }
        public string Comment { get; set; } = string.Empty;
    }
}