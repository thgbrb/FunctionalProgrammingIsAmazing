using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryScoreBoard.Core.Entity.Oracle;
using QueryScoreBoard.Repository.Repository;

namespace QueryScoreBoard.Domain
{
    public class ExecutionPlan
    {
        private readonly IUnityOfWork _unityOfWork;
        private const string EXPLAIN_PLAN = @"Explain plan for";

        public ExecutionPlan()
        {
            _unityOfWork = new UnityOfWork();
        }

        public ExecutionPlan(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public void SaveExecutionPlan(int sqlId)
        {
            var sql = _unityOfWork.Sql.FindBy(sqlId);
            var command = string.Format("{0}{1}", EXPLAIN_PLAN, sql.Text);
            _unityOfWork.DbContext.Database.ExecuteSqlCommand(command);
            var plan = _unityOfWork.Plan.FindAll();
            new SqlPlan(_unityOfWork).Save(sqlId, plan);
            new ExecutionAnalysis(_unityOfWork).Save(sqlId, plan);
            _unityOfWork.Save();
        }
    }
}
