namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class ScoreDetail : IEntityBase
    {
        public int Id { get; set; }
        public int CheckinAnalysisId { get; set; }
        public int MetricId { get; set; }
        public int CountMetric { get; set; }
        public int Sum { get; set; }
    }
}
