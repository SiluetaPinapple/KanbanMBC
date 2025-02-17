using System.ComponentModel.DataAnnotations;

namespace KanbanMBC.Components.Models
{
    public class Feeder
    {
        [Key]
        public string EPF { get; set; }
        public string? FeederName { get; set; }
    }
}
