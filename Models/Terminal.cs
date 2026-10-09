using System.Collections.Generic;

namespace LennujaamDBTask.Models
{
    public class Terminal
    {
        public int TerminalId { get; set; }
        public int TerminalNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

        public ICollection<Gate> Gates { get; set; } = new List<Gate>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}