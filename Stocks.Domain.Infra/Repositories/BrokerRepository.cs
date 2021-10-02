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
    public class BrokerRepository : IBrokerRepository
    {
        private readonly DataContext _context;

        public BrokerRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Broker broker)
        {
            _context.Brokers.Add(broker);
            _context.SaveChanges();
        }

        public IEnumerable<Broker> GetAll()
        {
            return _context.Brokers.AsNoTracking().OrderBy(BrokerQueries.GetAll());
        }

        public Broker GetById(Guid id)
        {
            return _context
                .Brokers
                .FirstOrDefault(BrokerQueries.GetById(id));
        }

        public void Update(Broker broker)
        {
            throw new NotImplementedException();
        }
    }
}
