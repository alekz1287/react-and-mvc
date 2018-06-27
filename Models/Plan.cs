using System.Collections.Generic;

namespace Models
{
    public class Plan
    {
        public int PlanId { get; set; }
        public string Name { get; set; }

        public List<LineItem> LineItems { get; set; }
    }
}