using System;
using QueryScoreBoard.Core.Entity.SQLMonitor;

namespace QueryScoreBoard.Core.Entity.Oracle
{
    public class Plan : IEntityBase
    {
        public int Id { get; set; }
        public long PlanId { get; set; }
        public long StatementId { get; set; }
        public int Instance { get; set; }
        public int SearchColumns { get; set; }
        public int Depth { get; set; }
        public int Cost { get; set; }
        public int Cardinality { get; set; }
        public int Bytes { get; set; }
        public int CPUCost { get; set; }
        public int IOCost { get; set; }
        public int Time { get; set; }
        public string Remarks { get; set; }
        public string Operation { get; set; }
        public string Options { get; set; }
        public string Node { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Alias { get; set; }
        public string Type { get; set; }
        public string Optimizer { get; set; }
        public string AccessPredicates { get; set; }
        public string FilterPredicates { get; set; }
        public DateTime Timestamp { get; set; }

    }
}
