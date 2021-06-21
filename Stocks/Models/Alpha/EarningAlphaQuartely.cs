using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models.Alpha
{
    public class EarningAlphaQuartely
    {
        public string fiscalDateEnding { get; set; }
        public string reportedDate { get; set; }
        public string reportedEPS { get; set; }
        public string estimatedEPS { get; set; }
        public string surprise { get; set; }
        public string surprisePercentage { get; set; }
    }
}
