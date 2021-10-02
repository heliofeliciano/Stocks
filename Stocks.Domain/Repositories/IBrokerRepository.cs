using Stocks.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Stocks.Domain.Repositories
{
    public interface IBrokerRepository
    {
        void Create(Broker broker);
        void Update(Broker broker);
        Broker GetById(Guid id);
        IEnumerable<Broker> GetAll();
    }
}
