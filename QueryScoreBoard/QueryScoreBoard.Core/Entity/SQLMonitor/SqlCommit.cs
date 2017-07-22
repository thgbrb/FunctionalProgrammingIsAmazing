using System;

namespace QueryScoreBoard.Core.Entity.SQLMonitor
{
    public class SqlCommit : EntityBase
    {
        public int SqlId { get; set; }
        public string UserName { get; set; }
        public int TfsBranchId { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
    }
}
