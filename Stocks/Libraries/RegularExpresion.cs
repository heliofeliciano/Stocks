using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stocks.Libraries
{
    public class RegularExpresion
    {
        private static Regex regexInstance;

        public RegularExpresion()
        {
        }

        public static MatchCollection GetMatches(string content, string pattern)
        {
            regexInstance = new Regex(pattern);
            return regexInstance.Matches(content);
        }

    }
}
