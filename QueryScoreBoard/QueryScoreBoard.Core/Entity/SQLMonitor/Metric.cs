namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class Metric : EntityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Factor { get; set; }
    }
}
