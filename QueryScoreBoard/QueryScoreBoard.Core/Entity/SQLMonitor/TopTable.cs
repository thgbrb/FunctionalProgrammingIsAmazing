namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class TopTable: IEntityBase
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public decimal Factor { get; set; }
    }
}
