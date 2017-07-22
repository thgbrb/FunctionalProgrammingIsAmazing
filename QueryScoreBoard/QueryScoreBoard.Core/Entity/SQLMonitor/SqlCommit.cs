using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM010_SQL_COMMIT")]
    public class SqlCommit : EntityBase
    {
        [Column("SM010_SQL_COMMIT_ID")]
        public override int Id { get; set; }

        [Column("SM001_SQL_ID")]
        public int SqlId { get; set; }

        [Column("SM010_USER")]
        public string UserName { get; set; }

        [Column("SM009_TFS_BRANCH_ID")]
        public int TfsBranchId { get; set; }

        [Column("SM010_DATE")]
        public DateTime Date { get; set; }

        [Column("SM010_COMMENT")]
        public string Comment { get; set; }
    }
}
