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
    public class StockRepository : IStockRepository
    {
        private readonly DataContext _context;

        public StockRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Stock stock)
        {
            _context.Stocks.Add(stock);
            _context.SaveChanges();
        }

        public IEnumerable<Stock> GetAll()
        {
            return _context
                .Stocks
                .Include(c => c.Company)
                .Include(sm => sm.StockMarket)
                .AsNoTracking().OrderBy(x => x.Ticker);
        }

        public IEnumerable<Stock> GetAllActive()
        {
            return _context.Stocks.AsNoTracking().Where(StockQueries.GetAllActive()).OrderBy(x => x.Ticker);
        }

        public IEnumerable<Stock> GetAllInactive()
        {
            return _context.Stocks.AsNoTracking().Where(StockQueries.GetAllInactive()).OrderBy(x => x.Ticker);
        }

        public Stock GetById(Guid id)
        {
            return _context.Stocks.FirstOrDefault(StockQueries.GetById(id));
        }

        public void Update(Stock stock)
        {
            _context.Entry(stock).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
