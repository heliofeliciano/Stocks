using System.Collections.Generic;

namespace Stocks.Models.Alpha
{
    public class DailyAdjustedAlpha : AlphaRequest
    {
        public string symbol { get; set; }
        public List<DailyAdjustedAlpha> dataReports { get; set; }
        public override string FunctionName => "TIME_SERIES_DAILY_ADJUSTED";
    }
}
