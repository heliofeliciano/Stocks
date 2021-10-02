using Stocks.Domain.Entities;
using Stocks.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace Stocks.Domain.Tests.Repositories
{
    public class FakeBrokerRepository : IBrokerRepository
    {
        public void Create(Broker broker)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Broker> GetAll()
        {
            throw new NotImplementedException();
        }

        public Broker GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Broker broker)
        {
            throw new NotImplementedException();
        }
    }
}
