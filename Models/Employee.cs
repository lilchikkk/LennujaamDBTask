namespace LennujaamDBTask.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int PositionId { get; set; }
        public Position? Position { get; set; }

        public int? TerminalId { get; set; }
        public Terminal? Terminal { get; set; }

        public string EmployeeNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
    }
}