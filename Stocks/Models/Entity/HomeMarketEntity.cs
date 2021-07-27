using System.Collections.Generic;

namespace Stocks.Models
{
    public class HomeMarketEntity : Entity
    {
        public string Name { get; set; }
        public List<StockEntity> Stocks { get; set; }
    }
}