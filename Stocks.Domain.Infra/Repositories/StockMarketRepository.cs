using Microsoft.EntityFrameworkCore;
using Stocks.Domain.Entities;
using Stocks.Domain.Infra.Contexts;
using Stocks.Domain.Queries;
using Stocks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stocks.Domain.Infra.Repositories
{
    public class StockMarketRepository : IStockMarketRepository
    {
        private readonly DataContext _context;

        public StockMarketRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(StockMarket stock)
        {
            _context.StockMarkets.Add(stock);
            _context.SaveChanges();
        }

        public IEnumerable<StockMarket> GetAll()
        {
            return _context.StockMarkets.AsNoTracking().OrderBy(x => x.Name);
        }

        public IEnumerable<StockMarket> GetAllActive()
        {
            return _context.StockMarkets.AsNoTracking().Where(StockMarketQueries.GetAllActive()).OrderBy(x => x.Name);
        }

        public IEnumerable<StockMarket> GetAllInactive()
        {
            return _context.StockMarkets.AsNoTracking().Where(StockMarketQueries.GetAllInactive()).OrderBy(x => x.Name);
        }

        public StockMarket GetById(Guid id)
        {
            return _context.StockMarkets.FirstOrDefault(StockMarketQueries.GetById(id));
        }

        public void Update(StockMarket stock)
        {
            _context.Entry(stock).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
