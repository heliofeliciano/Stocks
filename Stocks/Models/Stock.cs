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
        public TypeStock Type { get; set; }
        public HomeMarket HomeMarket { get; set; }
        public int HomeMarketId { get; set; }
        public Company Company { get; set; }
        public int CompanyId { get; set; }

        /*public enum eType
        {
            ON,
            PN,
            UNIT
        }*/
    }
}
