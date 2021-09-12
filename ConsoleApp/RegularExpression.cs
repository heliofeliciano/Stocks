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
        
        public static String GetResult(string content, string pattern)
        {
            regexInstance = new Regex(pattern);
            var matches = regexInstance.Matches(content);
            return matches[0].Groups[1].Value;
        }

        public static string GetOnlyNumbers(string content) => Regex.Replace(content, "[^0-9]", "");
    }
}