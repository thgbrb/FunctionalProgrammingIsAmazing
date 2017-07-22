using QueryScoreBoard.Analyzers;
using QueryScoreBoard.Core.Entity.SQLMonitor;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QueryScoreBoard.Analyzer
{
    public class AnalyzerRunner
    {
        public IList<MetricCountResult> Execute(string sqlText)
        {
            // Simula load de metricas
            var metricList = new List<Metric>()
            {
                new Metric()
                {
                    Id = 1,
                    Name = "distinct",
                    Factor = 1,
                    Description = "Count distincts"
                }
            };

            return new AnalyzerRunner().Count(sqlText, metricList);
        }

        /// <summary>
        /// Count words from a metric list given a sql text
        /// </summary>
        /// <param name="text">Sql Text</param>
        /// <param name="metricList">List of metrics to be analyzed</param>
        /// <returns>A metric count result</returns>
        private IList<MetricCountResult> Count(string text, IList<Metric> metricList)
        {
            var result = new List<MetricCountResult>();

            foreach (var metric in metricList)
            {
                var count = new Regex(string.Format(@"\b{0}\b", metric.Name), RegexOptions.IgnoreCase)
                    .Matches(text)
                    .Count;

                result.Add(MetricCountResult.Create(metric, count));
            }

            return result;
        }
    }
}