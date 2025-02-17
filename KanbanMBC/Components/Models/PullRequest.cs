using System.ComponentModel.DataAnnotations;

namespace KanbanMBC.Components.Models
{
    public class PullRequest
    {
        [Key]
        public int ID { get; set; }
        public string Model { get; set; }
        public string Head { get; set; }
        public DateTime? Date { get; set; }
        public string? TepKey { get; set; }
        public string? FedderA { get; set; }
        public string? Shift { get; set; }
        public string? FedderB { get; set; }


    }
}
