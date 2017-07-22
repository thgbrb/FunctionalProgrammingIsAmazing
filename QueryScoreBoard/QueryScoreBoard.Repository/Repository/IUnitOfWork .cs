using System;
using System.Collections.Generic;
using System.Text;
using QueryScoreBoard.Core.Entity.Oracle;
using QueryScoreBoard.Core.Entity.SQLMonitor;

namespace QueryScoreBoard.Repository.Repository
{
    public interface IUnitOfWork
    {
        Microsoft.EntityFrameworkCore.DbContext DbContext { get; }
        IGenericRepository<CheckinAnalysis> CheckinAnalysis { get; }
        IGenericRepository<QueryScoreBoard.Core.Entity.SQLMonitor.Environment> Environment { get; }
        IGenericRepository<ExecutionAnalysis> ExecutionAnalysis { get; }
        IGenericRepository<Metric> Metric { get; }
        IGenericRepository<ScoreDetail> ScoreDetail { get; }
        IGenericRepository<Sql> Sql { get; }
        IGenericRepository<SqlCommit> SqlCommit { get; }
        IGenericRepository<SqlPlan> SqlPlan { get; }
        IGenericRepository<TfsBranch> TfsBranch { get; }
        IGenericRepository<TopTable> TopTable { get; }
        IGenericRepository<Plan> Plan { get; }
        void Save();
    }
}
