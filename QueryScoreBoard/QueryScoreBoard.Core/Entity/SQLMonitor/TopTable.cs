namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class TopTable: EntityBase
    {
        public override int Id { get; set; }
        public string TableName { get; set; }
        public decimal Factor { get; set; }
    }
}
