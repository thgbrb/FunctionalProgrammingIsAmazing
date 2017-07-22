﻿using QueryScoreBoard.Analyzers;
using QueryScoreBoard.Core.Entity.SQLMonitor;
using QueryScoreBoard.Repository.Repository;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace QueryScoreBoard.Analyzer
{
    /// <summary>
    /// Run an analysis given a sql
    /// </summary>
    public class AnalyzerRunner
    {
        /// <summary>
        /// Receive an instance of Unit of Work
        /// </summary>
        private IUnityOfWork _unitOfWork;

        /// <summary>
        /// Default ctor and IoC
        /// </summary>
        public AnalyzerRunner()
        {
            _unitOfWork = new UnityOfWork();
        }

        /// <summary>
        /// Execute the analisys
        /// </summary>
        /// <param name="sqlText">Sql text to analysis</param>
        /// <returns>An analysis result</returns>
        public IList<MetricCountResult> Execute(string sqlText) =>
            new AnalyzerRunner().Count(sqlText, _unitOfWork.Metric.FindAll());

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