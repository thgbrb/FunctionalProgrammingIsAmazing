using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryScoreBoard.Domain
{
    internal class SqlPlan : PersistPlanBase
    {
        public SqlPlan(Repository.Repository.IUnityOfWork unityOfWork) : base(unityOfWork)
        {
        }

        public override void Save(int sqlId, List<Core.Entity.Oracle.Plan> plan)
        {
            plan.ForEach(o => _unityOfWork.SqlPlan.Add(
                        new Core.Entity.SQLMonitor.SqlPlan
                        {
                            SqlId = sqlId,
                            AccessPredicate = o.AccessPredicates,
                            FilterPredicate = o.FilterPredicates,
                            ObjectName = o.Name,
                            OperationCost = o.Cost,
                            OperationName = o.Operation
                            //Criar na tabela física o.CPUCost / o.IOCost
                        }
            ));
        }
    }
}
