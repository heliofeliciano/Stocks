using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibrary.Models
{
    public abstract class SearchEnginePattern
    {
        public abstract string GetPatternCNPJ();
        public abstract string GetPatternCompanyName();
        public abstract string GetPatternTicker();
        public abstract string GetCurrentQuote();
        public abstract string GetDY(int year);
    }
}
