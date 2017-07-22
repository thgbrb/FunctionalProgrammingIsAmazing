namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class Metric : EntityBase
    {
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Factor { get; set; }
    }
}
