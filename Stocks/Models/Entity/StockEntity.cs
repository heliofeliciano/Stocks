using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models
{
    public class StockEntity : Entity
    {
        public string Ticker { get; set; }
        public TypeStock Type { get; set; }
        public HomeMarketEntity HomeMarket { get; set; }
        public int HomeMarketId { get; set; }
        public CompanyEntity Company { get; set; }
        public int CompanyId { get; set; }

        /*public enum eType
        {
            ON,
            PN,
            UNIT
        }*/
    }
}
