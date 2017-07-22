using System;
using QueryScoreBoard.Core.Entity.SQLMonitor;
using System.ComponentModel.DataAnnotations.Schema;

namespace QueryScoreBoard.Core.Entity.Oracle
{
    [Table("PLAN_TABLE$", Schema = "SYS")]
    public class Plan : EntityBase
    {
        [Column("ID")]
        public override int Id { get => base.Id; set => base.Id = value; }

        [Column("PLAN_ID")]
        public long? PlanId { get; set; }

        [Column("STATEMENT_ID")]
        public long? StatementId { get; set; }

        [Column("OBJECT_INSTANCE")]
        public int? Instance { get; set; }

        [Column("SEARCH_COLUMNS")]
        public int? SearchColumns { get; set; }

        [Column("DEPTH")]
        public int? Depth { get; set; }

        [Column("COST")]
        public int? Cost { get; set; }

        [Column("CARDINALITY")]
        public int? Cardinality { get; set; }

        [Column("BYTES")]
        public int? Bytes { get; set; }

        [Column("CPU_COST")]
        public int? CPUCost { get; set; }

        [Column("IO_COST")]
        public int? IOCost { get; set; }

        [Column("TIME")]
        public int? Time { get; set; }

        [Column("REMARKS")]
        public string Remarks { get; set; }

        [Column("OPERATION")]
        public string Operation { get; set; }

        [Column("OPTIONS")]
        public string Options { get; set; }

        [Column("OBJECT_NODE")]
        public string Node { get; set; }

        [Column("OBJECT_NAME")]
        public string Name { get; set; }

        [Column("OBJECT_OWNER")]
        public string Owner { get; set; }

        [Column("OBJECT_ALIAS")]
        public string Alias { get; set; }

        [Column("OBJECT_TYPE")]
        public string Type { get; set; }

        [Column("OPTIMIZER")]
        public string Optimizer { get; set; }

        [Column("ACCESS_PREDICATES")]
        public string AccessPredicates { get; set; }

        [Column("FILTER_PREDICATES")]
        public string FilterPredicates { get; set; }

        [Column("TIMESTAMP")]
        public DateTime Timestamp { get; set; }
    }
}
