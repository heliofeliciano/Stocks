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
                    Name = "PETROBRAS",
                    DocumentNumber = "123456789"
                },
                Ticker = "PETR4"
            });
            list.Add(new Stock()
            {
                Id = 2,
                Company = new Company()
                {
                    Id = 1,
                    Name = "GUARARAPES",
                    DocumentNumber = "123456789"
                },
                Ticker = "GUAR3"
            });
            list.Add(new Stock()
            {
                Id = 2,
                Company = new Company()
                {
                    Id = 1,
                    Name = "VALE",
                    DocumentNumber = "123456789"
                },
                Ticker = "VALE3"
            });
            list.Add(new Stock()
            {
                Id = 2,
                Company = new Company()
                {
                    Id = 1,
                    Name = "JD.COM",
                    DocumentNumber = "123456789"
                },
                Ticker = "JD"
            });

            return list;
        }

        public void InsertingData()
        {
            var homeMarket = new HomeMarket()
            {
                Name = "B3"
            };

            var companyCNPJ = new Company()
            {
                Id = 1,
                Name = "PETROBRAS",
                DocumentNumber = "123456789"
            };

            var stock = new Stock()
            {
                Company = companyCNPJ,
                HomeMarket = homeMarket,
                Ticker = "PETR4"
            };

            

            using (var context = new StockContext())
            {
                context.HomeMarkets.Add(homeMarket);
                context.Companies.Add(companyCNPJ);
                context.Stocks.Add(stock);

                context.SaveChanges();
            }

        }

        
    }
}
