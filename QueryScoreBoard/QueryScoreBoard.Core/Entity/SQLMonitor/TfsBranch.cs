using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM009_TFS_BRANCH")]
    public class TfsBranch : EntityBase
    {
        [Column("SM009_TFS_BRANCH_ID")]
        public override int Id { get; set; }

        [Column("SM009_NAME")]
        public string Name { get; set; }
    }
}
