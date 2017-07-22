using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM001_SQL")]
    public class Sql : EntityBase
    {
        [Column("SM001_SQL_ID")]
        public override int Id { get; set; }

        [Column("SM001_HIS_SQL_ID")]
        public int HisSQLId { get; set; }

        [Column("SM001_SQL_TEXT")]
        public string Text { get; set; }

        [Column("SM001_SQL_CAPTURE")]
        public Capture Capture { get; set; }
    }

    public enum Capture
    {
        Commit = 1,
        Exec = 2,
        InitialLoad = 3
    }
}
