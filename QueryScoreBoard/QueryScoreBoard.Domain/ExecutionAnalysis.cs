using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryScoreBoard.Domain
{
    internal class ExecutionAnalysis : PersistPlanBase
    {
        public ExecutionAnalysis(Repository.Repository.IUnityOfWork unityOfWork) : base(unityOfWork)
        {
        }

        public override void Save(int sqlId, List<Core.Entity.Oracle.Plan> plan)
        {
            var random = new Random();
            _unityOfWork.ExecutionAnalysis.Add(new Core.Entity.SQLMonitor.ExecutionAnalysis
            {
                Id = random.Next(0, 100),
                ExecutionDuration = plan.Sum(o => o.Time),
                PlanCost = plan.Sum(o => o.Cost ?? 0),
                SqlId = sqlId
                //Criar na tabela física o.CPUCost / o.IOCost
            });
        }
    }
}
