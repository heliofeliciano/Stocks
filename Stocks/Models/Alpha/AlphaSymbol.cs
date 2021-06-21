using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models.Alpha
{
    public class AlphaSymbol
    {
        public string symbol { get; set; }
        public List<AlphaAnnualEarnings> annualEarnings { get; set; }
        public List<AlphaQuartelyEarnings> quarterlyEarnings { get; set; }
    }
}
