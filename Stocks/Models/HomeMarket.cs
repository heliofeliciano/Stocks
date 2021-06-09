using System.Collections.Generic;

namespace Stocks.Models
{
    public class HomeMarket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Stock> Stocks { get; set; }
    }
}