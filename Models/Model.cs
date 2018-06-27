using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Models
{
    public class PlanningContext : DbContext
    {
        public PlanningContext(DbContextOptions<PlanningContext> options)
            : base(options)
        { }

        public DbSet<Plan> Plans { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
    }
}