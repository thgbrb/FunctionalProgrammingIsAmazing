namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class ExecutionAnalysis : EntityBase
    {
        public override int Id { get; set; }
        public int SqlId { get; set; }
        public int PlanCost { get; set; }
        public long? ExecutionDuration { get; set; }
        public int EnvironmentId { get; set; }
        public string Comment { get; set; }
    }
}
