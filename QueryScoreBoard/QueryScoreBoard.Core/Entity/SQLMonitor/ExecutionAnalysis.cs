using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM006_EXEC_ANALYSIS")]
    public class ExecutionAnalysis : EntityBase
    {
        [Column("SM006_EXEC_ANALYSIS_ID")]
        public override int Id { get; set; }

        [Column("SM001_SQL_ID")]
        public int SqlId { get; set; }

        [Column("SM006_PLAN_COST")]
        public int PlanCost { get; set; }

        [Column("SM006_EXEC_DURATION")]
        public long? ExecutionDuration { get; set; }

        [Column("SM006_ENV_ID")]
        public int EnvironmentId { get; set; }

        [Column("SM006_COMMENT")]
        public string Comment { get; set; }
    }
}
