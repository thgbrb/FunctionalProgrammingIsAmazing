using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM002_METRIC")]
    public class Metric : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("SM002_METRIC_ID")]
        public override int Id { get; set; }

        [Column("SM002_NAME")]
        public string Name { get; set; }

        [Column("SM002_DESC")]
        public string Description { get; set; }

        [Column("SM002_FACTOR")]
        public int Factor { get; set; }
    }
}
