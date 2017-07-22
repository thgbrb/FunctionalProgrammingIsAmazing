using QueryScoreBoard.Analyzer;
using System;
using System.Text.RegularExpressions;
using Xunit;

namespace QueryScoreBoard.Tests
{
    public class AnalyzerTests
    {
        [Fact]
        public void ShouldCountAWordPatternInAText()
        {
            // Arrange

            var texto = $@"Select * from Alguma coisa Where teste.Id = ""Teste"" ";
            var pattern = "select";

            // Act

            var count = new Analyse().Count(texto, pattern);

            // Assert

            Assert.Equal(1, count);
        }
    }
}
