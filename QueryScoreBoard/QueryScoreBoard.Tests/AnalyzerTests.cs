using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueryScoreBoard.Analyzer;
using System.Linq;

namespace QueryScoreBoard.Tests
{
    [TestClass]
    public class AnalyzerTests
    {
        [TestMethod]
        public void ShouldCountAWordPatternInAText()
        {
            // Arrange

            var sql = $@"SELECT DISTINCT * FROM TABELAILUMINATI WHERE A IN (1,2,3,4,5)";


            // Act

            var count = new AnalyzerRunner().Execute(sql);

            // Assert

            Assert.AreEqual(1, count.Select(x => x.Count).Count());
        }
    }
}