using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace QueryScoreBoard.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TDD()
        {
            var teste = $@"Select * from Alguma coisa Where teste.Id = ""Teste"" ";

            var pattern = "Select";

            var regex = new Regex(string.Format(@"\b{0}\b", teste), RegexOptions.IgnoreCase);

            var count = regex.Matches(teste).Count;

            Assert.AreEqual(1, count);
        }
    }
}