namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class Sql : EntityBase
    {
        public decimal HisSQLId { get; set; }
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
