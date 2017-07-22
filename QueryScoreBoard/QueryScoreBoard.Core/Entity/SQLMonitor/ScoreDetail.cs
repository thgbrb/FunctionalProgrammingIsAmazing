using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM004_SCORE_DETAIL")]
    public class ScoreDetail : EntityBase
    {
        [Column("SM004_SCORE_DETAIL_ID")]
        public override int Id { get; set; }

        [Column("SM003_CHECKIN_ANALYSIS_ID")]
        public int CheckinAnalysisId { get; set; }

        [Column("SM002_METRIC_ID")]
        public int MetricId { get; set; }

        [Column("SM004_COUNT_METRIC")]
        public int CountMetric { get; set; }

        [Column("SM004_SUM_SCORE")]
        public int Sum { get; set; }
    }
}
