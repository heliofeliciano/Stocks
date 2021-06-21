using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models.Alpha
{
    public class CashFlowAlpha : AlphaRequest
    {
        public string symbol { get; set; }
        public List<CashflowAnnualReports> annualReports { get; set; }
        public List<CashflowQuarterlyReports> quarterlyReports { get; set; }

        public override string FunctionName => "CASH_FLOW";
    }
}
