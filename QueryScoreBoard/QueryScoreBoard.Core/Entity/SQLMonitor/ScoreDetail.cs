namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class ScoreDetail : EntityBase
    {
        public int CheckinAnalysisId { get; set; }
        public int MetricId { get; set; }
        public int CountMetric { get; set; }
        public int Sum { get; set; }
    }
}
