using Stocks.Models;
using System.Collections;
using System.Collections.Generic;

namespace Stocks.Libraries
{
    public class DataContent
    {
        public List<Stock> GetStocks()
        {
            var list = new List<Stock>();
            list.Add(new Stock()
            {
                Id = 1,
                Company = new Company()
                {
                    Id = 1,
                    Name = "PETROBRAS"
                },
                Ticker = "PETR4"
            });

            list.Add(new Stock()
            {
                Id = 2,
                Company = new Company()
                {
                    Id = 1,
                    Name = "GUARARAPES"
                },
                Ticker = "GUAR3"
            });
            
            list.Add(new Stock()
            {
                Id = 2,
                Company = new Company()
                {
                    Id = 1,
                    Name = "GUARARAPES"
                },
                Ticker = "GUAR3"
            });

            return null;
        }
    }
}
