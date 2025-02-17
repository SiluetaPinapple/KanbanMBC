using System.ComponentModel.DataAnnotations;

namespace KanbanMBC.Components.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        public string? MODULES { get; set; }
        public string? EPF { get; set; }
        public string? Heads { get; set; }
        public DateTime Date { get; set; }

    }
}
