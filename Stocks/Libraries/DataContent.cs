using Stocks.Data;
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
                    Name = "VALE"
                },
                Ticker = "VALE3"
            });
            list.Add(new Stock()
            {
                Id = 2,
                Company = new Company()
                {
                    Id = 1,
                    Name = "JD.COM"
                },
                Ticker = "JDCO34"
            });

            return list;
        }

        public void InsertingData()
        {
            var homeMarket = new HomeMarket()
            {
                Name = "B3"
            };

            var identify = new Identify()
            {
                Name = "CNPJ"
            };

            var company = new Company()
            {
                Name = "PETROBRAS",
                Identify = identify
            };

            var stock = new Stock()
            {
                Company = company,
                HomeMarket = homeMarket,
                Ticker = "PETR4"
            };

            

            using (var context = new StockContext())
            {
                context.HomeMarkets.Add(homeMarket);
                context.Identifies.Add(identify);
                context.Companies.Add(company);
                context.Stocks.Add(stock);

                context.SaveChanges();
            }

        }

        
    }
}
