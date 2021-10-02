using Stocks.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Stocks.Domain.Queries
{
    public class BrokerQueries
    {
        public static Expression<Func<Broker, bool>> GetAll()
        {
            return x => x.Id != null;
        }

        public static Expression<Func<Broker, bool>> GetAllActive()
        {
            return x => x.Id != null;
        }

        public static Expression<Func<Broker, bool>> GetAllInactive()
        {
            return x => x.Id != null;
        }

        public static Expression<Func<Broker, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}
