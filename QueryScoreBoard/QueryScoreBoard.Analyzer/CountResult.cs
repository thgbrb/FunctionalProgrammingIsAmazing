namespace QueryScoreBoard.Analyzers
{
    /// <summary>
    /// Object result of an analize
    /// </summary>
    public class CountResult
    {
        /// <summary>
        /// Text analized
        /// </summary>
        public string Pattern { get; set; }
        /// <summary>
        /// Number of text couting
        /// </summary>
        public int Count { get; set; }
    }
}
