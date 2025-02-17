using System.ComponentModel.DataAnnotations;

namespace KanbanMBC.Components.Models
{
    public class FredderAssign
    {
        [Key]
        public required string Lin { get; set; }
        public string? ShiftA  {get; set; }
        public string? ShiftB { get; set; }
    }
}
