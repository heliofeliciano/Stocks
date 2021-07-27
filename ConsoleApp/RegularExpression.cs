using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    public class RegularExpression
    {
        private static Regex regexInstance;

        public static MatchCollection GetMatches(string content, string pattern)
        {
            regexInstance = new Regex(pattern);
            return regexInstance.Matches(content);
        }
    }
}
