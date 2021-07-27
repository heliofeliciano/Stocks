using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models.Alpha
{
    public class DailyAdjustedAlphaData
    {
        public string Open { get; set; }
        public string High { get; set; }
        public string Low { get; set; }
        public string Close { get; set; }
        public string AdjustedClose { get; set; }
        public string Volume { get; set; }
        public string DividendAmount { get; set; }
        public string SplitCoefficient { get; set; }
    }
}
