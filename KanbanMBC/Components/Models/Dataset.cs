using System.ComponentModel.DataAnnotations;

namespace KanbanMBC.Components.Models
{
    public class Dataset
    {
        [Key]
        public int ID { get; set; }
        public string? MODULE { get; set; }
        public string? Heads { get; set; }
        public string? Fedders { get; set; }
        public string? EPF { get; set; }

    }

}
