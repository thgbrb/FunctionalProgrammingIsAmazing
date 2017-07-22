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
            var random = new Random();
            plan.ForEach(o => _unityOfWork.SqlPlan.Add(
                        new Core.Entity.SQLMonitor.SqlPlan
                        {
                            Id = random.Next(0, 100),
                            SqlId = sqlId,
                            AccessPredicate = o.AccessPredicates,
                            FilterPredicate = o.FilterPredicates,
                            ObjectName = string.IsNullOrEmpty(o.Name) ? "espaço vazio" : o.Name,
                            OperationCost = o.Cost ?? 0,
                            OperationName = o.Operation
                            //Criar na tabela física o.CPUCost / o.IOCost
                        }
            ));
        }
    }
}
