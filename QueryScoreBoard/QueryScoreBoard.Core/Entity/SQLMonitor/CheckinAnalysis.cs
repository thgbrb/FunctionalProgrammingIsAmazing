using System;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class CheckinAnalysis : EntityBase
    {
        public decimal SqlId { get; set; }
        public decimal PlanCost { get; set; }
        public decimal Score { get; set; }
        public DateTime ExecutionDate { get; set; }
    }
}
