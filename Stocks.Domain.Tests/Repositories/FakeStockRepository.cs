using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Repositories;
using Stocks.Domain.ValueObjects;
using System;

namespace Stocks.Domain.Tests.Repositories
{
    public class FakeStockRepository : IStockRepository
    {
        public void Create(Stock stock)
        {
        }

        public Stock GetById(Guid id)
        {
            return new Stock(new Company("Company Test", new Document("123", EDocumentType.CNPJ)), "CT", new StockMarket("B3"));
        }

        public void Update(Stock stock)
        {
        }
    }
}
