using QueryScoreBoard.Core.Entity.SQLMonitor;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void CalculateScore()
        {
            Metric distinctMetric = new Metric() { Name = "Distinct", Factor = 3, Id = 1 };
            int distinctCount = 2;

            List<ScoreDetail> scores = new List<ScoreDetail>();
            ScoreDetail scoreDetailDistinct = new ScoreDetail();
            scoreDetailDistinct.CountMetric = distinctCount;
            scoreDetailDistinct.MetricId = distinctMetric.Id;
            scoreDetailDistinct.Sum = distinctMetric.Factor * distinctCount;
            scores.Add(scoreDetailDistinct);

            Metric leftMetric = new Metric() { Name = "Left", Factor = 2, Id = 1 };
            int leftCount = 5;

            ScoreDetail scoreDetailLeft = new ScoreDetail();
            scoreDetailLeft.CountMetric = distinctCount;
            scoreDetailLeft.MetricId = leftMetric.Id;
            scoreDetailLeft.Sum = leftMetric.Factor * leftCount;
            scores.Add(scoreDetailLeft);

            CheckinAnalysis checkinAnalysis = new CheckinAnalysis();
            checkinAnalysis.ExecutionDate = DateTime.Now;
            checkinAnalysis.Score = scores.Sum(o => o.Sum);
            checkinAnalysis.SqlId = 1;

            Assert.True((scoreDetailDistinct.Sum + scoreDetailLeft.Sum) == checkinAnalysis.Score);
        }
    }
}
