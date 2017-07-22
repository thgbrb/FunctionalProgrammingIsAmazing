using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM003_CHECKIN_ANALYSIS")]
    public class CheckinAnalysis : EntityBase
    {
        [Column("SM003_CHECKIN_ANALYSIS_ID")]
        public override int Id { get; set; }

        [Column("SM001_SQL_ID")]
        public int SqlId { get; set; }

        [Column("SM003_PLAN_COST")]
        public long PlanCost { get; set; }

        [Column("SM003_SCORE")]
        public long Score { get; set; }

        [Column("SM003_EXEC_TIME")]
        public DateTime ExecutionDate { get; set; }
    }
}
