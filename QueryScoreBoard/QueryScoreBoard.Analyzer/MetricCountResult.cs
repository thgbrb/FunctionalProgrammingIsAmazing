using QueryScoreBoard.Core.Entity.SQLMonitor;
using System;

namespace QueryScoreBoard.Analyzers
{
    /// <summary>
    /// Object result of an analize
    /// </summary>
    public class MetricCountResult
    {
        /// <summary>
        /// Metric Object
        /// </summary>
        public Metric Metric { get; private set; }
        /// <summary>
        /// Number of text couting
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Default ctor
        /// </summary>
        /// <param name="metric">Metric object to be analyzed</param>
        /// <param name="count">Numbers of metric word found</param>
        public MetricCountResult(Metric metric, int count)
        {
            Metric = metric;
            Count = count;
        }

        /// <summary>
        /// Creates a new MetricCountResult object
        /// </summary>
        /// <param name="metric">Metric Id</param>
        /// <param name="count">Numbers of metric word found</param>
        /// <returns></returns>
        public static MetricCountResult Create(Metric metric, int count) =>
            new MetricCountResult(metric, count);
    }
}