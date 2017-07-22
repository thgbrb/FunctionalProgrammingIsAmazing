using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM008_TOP_TABLES")]
    public class TopTable: EntityBase
    {
        [Column("SM008_TOP_TABLES_ID")]
        public override int Id { get; set; }

        [Column("SM008_TABLE_NAME")]
        public string TableName { get; set; }

        [Column("SM008_FACTOR")]
        public decimal Factor { get; set; }
    }
}
