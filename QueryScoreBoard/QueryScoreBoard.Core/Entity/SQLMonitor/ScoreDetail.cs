namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class ScoreDetail : EntityBase
    {
        public decimal CheckinAnalysisId { get; set; }
        public decimal MetricId { get; set; }
        public decimal CountMetric { get; set; }
        public decimal Sum { get; set; }
    }
}
