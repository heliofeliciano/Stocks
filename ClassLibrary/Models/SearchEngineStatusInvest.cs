using System;
using System.Text.RegularExpressions;

namespace ClassLibrary.Models
{
    public class SearchEngineStatusInvest : SearchEnginePattern
    {
        public override string GetCurrentQuote() => @"Valor atual<\/h3>\n<span.*\n<strong.*\"">(.*)<\/strong>";
        public override string GetPatternCNPJ() => @"([0-9]{2}[\.][0-9]{3}[\.][0-9]{3}[\/][0-9]{4}[-][0-9]{2})";
        public override string GetPatternCompanyName() => @"<small>(.*?)<\/small>";
        public override string GetPatternTicker() => @"<title>([A-Z0-9]*)";
        public override string GetDY(int year)
        {
            throw new NotImplementedException();
        }
    }
}
