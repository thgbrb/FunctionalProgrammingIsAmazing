using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM005_ENVIRONMENT")]
    public class Environment : EntityBase
    {
        [Column("SM005_ENVIRONMENT_ID")]
        public override int Id { get; set; }

        [Column("SM005_DESCRIPTION")]
        public string Description { get; set; }
    }
}
