namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class TopTable: EntityBase
    {
        public string TableName { get; set; }
        public decimal Factor { get; set; }
    }
}
