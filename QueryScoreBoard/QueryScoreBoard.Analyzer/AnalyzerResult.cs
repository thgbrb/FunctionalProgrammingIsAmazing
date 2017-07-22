using QueryScoreBoard.Core.Entity.SQLMonitor;
using System.Collections.Generic;

namespace QueryScoreBoard.Analyzers
{
    /// <summary>
    /// Result of analyses
    /// </summary>
    public class AnalyzerResult
    {
        /// <summary>
        /// Sql Identification
        /// </summary>
        public string SqlId { get; set; }
        /// <summary>
        /// Sql Text analized
        /// </summary>
        public string SqlText { get; set; }
        /// <summary>
        /// Inform the capture type used
        /// </summary>
        public Capture CaptureType { get; set; }
        /// <summary>
        /// Metric list with its couting
        /// </summary>
        public IList<MetricCountResult> MetricsCount { get; set; }
    }
}