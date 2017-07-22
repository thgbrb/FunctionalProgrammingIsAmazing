using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueryScoreBoard.Analyzer;

namespace QueryScoreBoard.Tests
{
    [TestClass]
    public class AnalyzerTests
    {
        [TestMethod]
        public void ShouldCountAWordPatternInAText()
        {
            // Arrange

            var texto = $@"Select * from Alguma coisa Where teste.Id = ""Teste"" ";
            var pattern = "select";

            // Act

            var count = new Analyse().Count(texto, pattern);

            // Assert

            Assert.AreEqual(1, count);
        }
    }
}
