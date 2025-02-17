using System.ComponentModel.DataAnnotations;

namespace KanbanMBC.Components.Models
{
    public class LoginModel
    {
        [Key]
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
