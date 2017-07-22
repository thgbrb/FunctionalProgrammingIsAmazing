namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class SqlPlan : IEntityBase
    {
        public int Id { get; set; }
        public int SqlId { get; set; }
        public string OperationName { get; set; }
        public int OperationCost { get; set; }
        public string ObjectName { get; set; }
        public string AccessPredicate { get; set; }
        public string FilterPredicate { get; set; }
    }
}
