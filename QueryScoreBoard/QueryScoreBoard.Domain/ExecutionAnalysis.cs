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
            _unityOfWork.ExecutionAnalysis.Add(new Core.Entity.SQLMonitor.ExecutionAnalysis
            {
                ExecutionDuration = plan.Sum(o => o.Time),
                PlanCost = plan.Sum(o => o.Cost),
                SqlId = sqlId
                //Criar na tabela física o.CPUCost / o.IOCost
            });
        }
    }
}
