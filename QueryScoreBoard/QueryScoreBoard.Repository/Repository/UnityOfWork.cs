using QueryScoreBoard.Core.Entity.Oracle;
using QueryScoreBoard.Core.Entity.SQLMonitor;
using QueryScoreBoard.Repository.Context;
using System.Data.Entity;

namespace QueryScoreBoard.Repository.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly DbContext _dbContext;
        private IGenericRepository<CheckinAnalysis> _checkinAnalysis;
        private IGenericRepository<QueryScoreBoard.Core.Entity.SQLMonitor.Environment> _environment;
        private IGenericRepository<ExecutionAnalysis> _executionAnalysis;
        private IGenericRepository<Metric> _metric;
        private IGenericRepository<ScoreDetail> _scoreDetail;
        private IGenericRepository<Sql> _sql;
        private IGenericRepository<SqlCommit> _sqlCommit;
        private IGenericRepository<SqlPlan> _sqlPlan;
        private IGenericRepository<TfsBranch> _tfsBranch;
        private IGenericRepository<TopTable> _topTable;
        private IGenericRepository<Plan> _plan;

        public UnityOfWork()
        {
            //Desculpa ¯\_(ツ)_/¯
            var connString = "User Id=SQLMON;Password=sqlmon$adm;Host=10.51.3.41/dbsaude2;";
           
            _dbContext = new DbContextBase(connString);
        }

        public UnityOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public DbContext DbContext
        {
            get
            {
                return _dbContext;
            }
        }

        public IGenericRepository<CheckinAnalysis> CheckinAnalysis
        {
            get
            {
                if (_checkinAnalysis == null)
                    _checkinAnalysis = new GenericRepository<CheckinAnalysis>(_dbContext);
                return _checkinAnalysis;
            }
        }

        public IGenericRepository<QueryScoreBoard.Core.Entity.SQLMonitor.Environment> Environment
        {
            get
            {
                if (_environment == null)
                 _environment = new GenericRepository<QueryScoreBoard.Core.Entity.SQLMonitor.Environment>(_dbContext);
                return _environment;
            }
        }

        public IGenericRepository<ExecutionAnalysis> ExecutionAnalysis
        {
            get
            {
                if (_executionAnalysis == null)
                    _executionAnalysis = new GenericRepository<ExecutionAnalysis>(_dbContext);
                return _executionAnalysis;
            }
        }

        public IGenericRepository<Metric> Metric
        {
            get
            {
                if (_metric == null)
                    _metric = new GenericRepository<Metric>(_dbContext);
                return _metric;
            }
        }

        public IGenericRepository<ScoreDetail> ScoreDetail
        {
            get
            {
                if (_scoreDetail == null)
                    _scoreDetail = new GenericRepository<ScoreDetail>(_dbContext);
                return _scoreDetail;
            }
        }

        public IGenericRepository<Sql> Sql
        {
            get
            {
                if (_sql == null)
                    _sql = new GenericRepository<Sql>(_dbContext);
                return _sql;
            }
        }

        public IGenericRepository<SqlCommit> SqlCommit
        {
            get
            {
                if (_sqlCommit == null)
                    _sqlCommit = new GenericRepository<SqlCommit>(_dbContext);
                return _sqlCommit;
            }
        }

        public IGenericRepository<SqlPlan> SqlPlan
        {
            get
            {
                if (_sqlPlan == null)
                    _sqlPlan = new GenericRepository<SqlPlan>(_dbContext);
                return _sqlPlan;
            }
        }

        public IGenericRepository<TfsBranch> TfsBranch
        {
            get
            {
                if (_tfsBranch == null)
                    _tfsBranch = new GenericRepository<TfsBranch>(_dbContext);
                return _tfsBranch;
            }
        }

        public IGenericRepository<TopTable> TopTable
        {
            get
            {
                if (_topTable == null)
                    _topTable = new GenericRepository<TopTable>(_dbContext);
                return _topTable;
            }
        }

        public IGenericRepository<Plan> Plan
        {
            get
            {
                if (_plan == null)
                    _plan = new GenericRepository<Plan>(_dbContext);
                return _plan;
            }
        }
    }
}
