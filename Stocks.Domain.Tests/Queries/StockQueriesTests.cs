using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Queries;
using Stocks.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stocks.Domain.Tests.Queries
{
    [TestClass]
    public class StockQueriesTests
    {
        private List<Stock> _items;

        public StockQueriesTests()
        {
            _items = new List<Stock>();
            var stock01 = new Stock(new Company("APPLE", new Document("123", EDocumentType.CNPJ)),"AAPL", new StockMarket("NASDAQ"));
            var stock02 = new Stock(new Company("APPLE", new Document("123", EDocumentType.CNPJ)),"AAPL", new StockMarket("NASDAQ"));
            var stock03 = new Stock(new Company("APPLE", new Document("123", EDocumentType.CNPJ)),"AAPL", new StockMarket("NASDAQ"));
            var stock04 = new Stock(new Company("APPLE", new Document("123", EDocumentType.CNPJ)),"AAPL", new StockMarket("NASDAQ"));
            var stock05 = new Stock(new Company("APPLE", new Document("123", EDocumentType.CNPJ)), "AAPL", new StockMarket("NASDAQ"));
            stock01.InactivateStock();
            stock04.InactivateStock();

            _items.Add(stock01);
            _items.Add(stock02);
            _items.Add(stock03);
            _items.Add(stock04);
            _items.Add(stock05);
        }

        [TestMethod]
        public void Dado_a_consulta_deve_retornar_stocks_apenas_ativas()
        {
            var result = _items.AsQueryable().Where(StockQueries.GetAllActive());
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void Dado_a_consulta_deve_retornar_stocks_apenas_inativas()
        {
            var result = _items.AsQueryable().Where(StockQueries.GetAllInactive());
            Assert.AreEqual(2, result.Count());
        }

        [TestMethod]
        public void Dado_um_novo_guid_lista_deve_conter_zero_elementos()
        {
            var id = Guid.NewGuid();

            var result = _items.AsQueryable().Where(StockQueries.GetById(id));

            Assert.AreEqual(0, result.Count());
        }
    }
}
