using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.Annotations;
using QueryScoreBoard.Core.Entity.SQLMonitor;
using QueryScoreBoard.Core.Entity.Oracle;

namespace QueryScoreBoard.Repository.Context
{
    public class DbContextBase : DbContext
    {
        public DbSet<CheckinAnalysis> CheckinAnalysis { get; set; }
        public DbSet<QueryScoreBoard.Core.Entity.SQLMonitor.Environment> Environment { get; set; }
        public DbSet<ExecutionAnalysis> ExecutionAnalysis { get; set; }
        public DbSet<Metric> Metric { get; set; }
        public DbSet<ScoreDetail> ScoreDetail { get; set; }
        public DbSet<Sql> Sql { get; set; }
        public DbSet<SqlCommit> SqlCommit { get; set; }
        public DbSet<SqlPlan> SqlPlan { get; set; }
        public DbSet<TfsBranch> TfsBranch { get; set; }
        public DbSet<TopTable> TopTable { get; set; }
        public DbSet<Plan> Plan { get; set; }

        public DbContextBase(DbContextOptions options) : base(options)
        {
        }
    }
}
