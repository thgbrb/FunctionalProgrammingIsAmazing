using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    [Table("SM007_SQL_PLAN")]
    public class SqlPlan : EntityBase
    {
        [Column("SM007_SQL_PLAN_ID")]
        public override int Id { get; set; }

        [Column("SM001_SQL_ID")]
        public int SqlId { get; set; }

        [Column("SM007_OP_NAME")]
        public string OperationName { get; set; }

        [Column("SM007_OP_COST")]
        public int OperationCost { get; set; }

        [Column("SM007_OBJECT_NAME")]
        public string ObjectName { get; set; }

        [Column("SM007_ACCESS_PRED")]
        public string AccessPredicate { get; set; }

        [Column("SM007_FILTER_PRED")]
        public string FilterPredicate { get; set; }
    }
}
