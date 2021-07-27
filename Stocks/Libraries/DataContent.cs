using Stocks.Data;
using Stocks.Models;
using System.Collections;
using System.Collections.Generic;

namespace Stocks.Libraries
{
    public class DataContent
    {
        public List<StockEntity> GetStocks()
        {
            var list = new List<StockEntity>();
            list.Add(new StockEntity()
            {
                Company = new CompanyEntity()
                {
                    Name = "PETROBRAS",
                    DocumentNumber = "123456789"
                },
                Ticker = "PETR4"
            });
            list.Add(new StockEntity()
            {
                Company = new CompanyEntity()
                {
                    Name = "GUARARAPES",
                    DocumentNumber = "123456789"
                },
                Ticker = "GUAR3"
            });
            list.Add(new StockEntity()
            {
                Company = new CompanyEntity()
                {
                    Name = "VALE",
                    DocumentNumber = "123456789"
                },
                Ticker = "VALE3"
            });
            list.Add(new StockEntity()
            {
                Company = new CompanyEntity()
                {
                    Name = "JD.COM",
                    DocumentNumber = "123456789"
                },
                Ticker = "JD"
            });

            return list;
        }

        public void InsertingData()
        {
            var homeMarket = new HomeMarketEntity()
            {
                Name = "B3"
            };

            var companyCNPJ = new CompanyEntity()
            {
                Name = "PETROBRAS",
                DocumentNumber = "123456789",
                Country = new CountryEntity()
                {
                    Name = "Brazil",
                    Sigla = "BR"
                }
            };

            var typeStock = new TypeStock()
            {
                Name = "Stock_BRL"
            };

            var stock = new StockEntity()
            {
                Company = companyCNPJ,
                HomeMarket = homeMarket,
                Type = typeStock,
                Ticker = "PETR4"
            };

            

            using (var context = new StockContext())
            {
                context.Stocks.Add(stock);

                context.SaveChanges();
            }

        }

        
    }
}
