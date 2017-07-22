namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class ExecutionAnalysis : EntityBase
    {
        public decimal SqlId { get; set; }
        public decimal PlanCost { get; set; }
        public decimal? ExecutionDuration { get; set; }
        public decimal EnvironmentId { get; set; }
        public string Comment { get; set; }
    }
}
