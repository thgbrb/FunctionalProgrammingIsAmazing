using System;
using System.Text.RegularExpressions;
using Xunit;

namespace QueryScoreBoard.Tests
{
    public class AnalyzerTests
    {
        [Fact]
        public void TDD()
        {
            var teste = $@"Select * from Alguma coisa Where teste.Id = ""Teste"" ";

            var pattern = "Select";

            var regex = new Regex(string.Format(@"\b{0}\b", teste), RegexOptions.IgnoreCase);

            var count = regex.Matches(teste).Count;

            Assert.Equal(1, count);
        }
    }
}
