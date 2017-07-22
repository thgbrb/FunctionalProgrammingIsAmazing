using System;
using System.Collections.Generic;
using System.Text;

namespace QueryScoreBoard.Analyzers
{
    public class AnalyzeResult
    {
        public string SqlId { get; set; }
        public string SqlText { get; set; }        
        public IList<CountResult> MetricsCount { get; set; }
    }
}
