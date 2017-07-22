﻿using System;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class CheckinAnalysis : IEntityBase
    {
        public int Id { get; set; }
        public int SqlId { get; set; }
        public long PlanCost { get; set; }
        public long Score { get; set; }
        public DateTime ExecutionDate { get; set; }
    }
}
