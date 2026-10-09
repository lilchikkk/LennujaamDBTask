using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class Position
    {
        public int PositionId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}