using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KanbanMBC.Components.Models;

namespace KanbanMBC.Data
{
    public class KanbanMBCContext : DbContext
    {
        public KanbanMBCContext (DbContextOptions<KanbanMBCContext> options)
            : base(options)
        {
        }

        public DbSet<KanbanMBC.Components.Models.PullRequest> PullRequest { get; set; } = default!;
        public DbSet<KanbanMBC.Components.Models.Dataset> Dataset { get; set; } = default!;
        public DbSet<KanbanMBC.Components.Models.FredderAssign> FredderAssign { get; set; } = default!;
        public DbSet<KanbanMBC.Components.Models.Login> Login { get; set; } = default!;
        public DbSet<KanbanMBC.Components.Models.LoginModel> LoginModel { get; set; } = default!;
        public DbSet<KanbanMBC.Components.Models.Feeder> Feeder { get; set; } = default!;
    }
}
