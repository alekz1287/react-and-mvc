namespace Models
{
    public class LineItem
    {
        public int LineItemId { get; set; }
        public string Description { get; set; }

        public int PlanId { get; set; }
        public Plan Plan { get; set; }
    }
}