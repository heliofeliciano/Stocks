using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Repositories;
using Stocks.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace Stocks.Domain.Tests.Repositories
{
    public class FakeStockRepository : IStockRepository
    {
        public void Create(Stock stock)
        {
        }

        public IEnumerable<Stock> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> GetAllInactive()
        {
            throw new NotImplementedException();
        }

        public Stock GetById(Guid id)
        {
            return new Stock(new Company("Company Test", new Document("123", EDocumentType.CNPJ)).Id, "CT", new StockMarket("B3").Id, EStockType.BDR);
        }

        public void Update(Stock stock)
        {
        }
    }
}
