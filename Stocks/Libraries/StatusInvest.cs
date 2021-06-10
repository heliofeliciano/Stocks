using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Libraries
{
    public class StatusInvest
    {
        public string PatternCurrentValue 
        {
            get { return @"Valor atual<\/h3>\s<span class=\""icon\"">R.<\/span>\s<strong class=\""value\"">(\d+,\d+)<\/strong>"; }
            private set { PatternCurrentValue = value;  }
        }
        public string PatterParity
        {
            get { return @"(\d)\sStock = (\d+)"; }
            private set { PatterParity = value; }
        }

        public string Site
        {
            get { return "https://statusinvest.com.br/bdrs"; }
            private set { Site = value; }
        }
    }
}
