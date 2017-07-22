using System.Text.RegularExpressions;

namespace QueryScoreBoard.Analyzer
{
    public class Analyse
    {
        /// <summary>
        /// Count a pattern in a given text
        /// </summary>
        /// <param name="text">Text to be analyzed</param>
        /// <param name="pattern">Pattern to search</param>
        /// <returns></returns>
        public int Count(string text, string pattern) =>
            new Regex(string.Format(@"\b{0}\b", pattern), RegexOptions.IgnoreCase)
                .Matches(text)
                .Count;
    }
}