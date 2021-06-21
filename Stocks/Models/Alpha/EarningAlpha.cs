using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models.Alpha
{
    /*
     * Lucro por Ação
     */
    public class EarningAlpha : AlphaRequest
    {
        public string symbol { get; set; }
        public List<EarningAlphaAnnual> annualEarnings { get; set; }
        public List<EarningAlphaQuartely> quarterlyEarnings { get; set; }

        public override string FunctionName => "EARNINGS";
    }
}
