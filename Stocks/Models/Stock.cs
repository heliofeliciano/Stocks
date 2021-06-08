using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string Type { get; set; } // TODO will see another name for this variable
        public HomeMarket HomeMarket { get; set; }
        public int HomeMarketId { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }
    }
}
