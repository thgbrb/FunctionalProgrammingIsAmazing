namespace QueryScoreBoard.Analyzers
{
    /// <summary>
    /// Object result of an analize
    /// </summary>
    public class MetricCountResult
    {
        /// <summary>
        /// Text analized
        /// </summary>
        public int MetricId { get; set; }
        /// <summary>
        /// Number of text couting
        /// </summary>
        public int Count { get; set; }
    }
}
