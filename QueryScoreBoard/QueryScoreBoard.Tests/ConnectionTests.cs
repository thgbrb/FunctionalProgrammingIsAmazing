using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueryScoreBoard.Domain;
using System.Linq;

namespace QueryScoreBoard.Tests
{
    [TestClass]
    public class ConnectionTests
    {
        [TestMethod]
        public void CreateContext()
        {
            Repository.Repository.IUnityOfWork uow = new Repository.Repository.UnityOfWork();
            var list = uow.CheckinAnalysis.FindAll();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void CreateMetric()
        {
            Repository.Repository.IUnityOfWork uow = new Repository.Repository.UnityOfWork();

            var metrics = uow.Metric.FindAll();

            if (!metrics.Any(o => o.Name == "DISTINCT"))
            {
                uow.Metric.Add(new Core.Entity.SQLMonitor.Metric
                {
                    Id = 1,
                    Description = "FAZ DISTINCT DOS DADOS",
                    Factor = 1,
                    Name = "DISTINCT"
                });
            }
            if (!metrics.Any(o => o.Name == "LEFT JOIN"))
            {
                uow.Metric.Add(new Core.Entity.SQLMonitor.Metric
                {
                    Id = 2,
                    Description = "FAZ UMA JUNÇÃO À ESQUERDA",
                    Factor = 1,
                    Name = "LEFT JOIN"
                });
            }
            uow.Save();
        }

        [TestMethod]
        public void CreateSQL()
        {
            Repository.Repository.IUnityOfWork uow = new Repository.Repository.UnityOfWork();
            var sql = uow.Sql.FindBy(1);

            if (sql == null)
            {
                uow.Sql.Add(new Core.Entity.SQLMonitor.Sql
                {
                    Id = 1,
                    Capture = Core.Entity.SQLMonitor.Capture.InitialLoad,
                    Text = "SELECT * SM002_METRIC"
                });
            }
            uow.Save();
        }

        [TestMethod]
        public void CapturePlan()
        {
            new ExecutionPlan().CapturePlan(1);
        }
    }
}
