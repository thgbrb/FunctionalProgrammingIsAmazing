namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class Sql : IEntityBase
    {
        public int Id { get; set; }
        public int HisSQLId { get; set; }
        public string Text { get; set; }
        public Capture Capture { get; set; }
    }

    public enum Capture
    {
        Commit = 1,
        Exec = 2,
        InitialLoad = 3
    }
}
