using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryScoreBoard.Domain
{
    internal abstract class PersistPlanBase
    {
        protected readonly Repository.Repository.IUnityOfWork _unityOfWork;

        public PersistPlanBase(Repository.Repository.IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public abstract void Save(int sqlId, List<Core.Entity.Oracle.Plan> plan);
    }
}
