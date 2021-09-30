using Stocks.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Stocks.Domain.Queries
{
    public class StockQueries
    {
        public static Expression<Func<Stock, bool>> GetAll()
        {
            return x => x.Id != null;
        }

        public static Expression<Func<Stock, bool>> GetAllActive()
        {
            return x => x.Id != null && x.Active == true;
        }

        public static Expression<Func<Stock, bool>> GetAllInactive()
        {
            return x => x.Id != null && x.Active == false;
        }

        public static Expression<Func<Stock, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}
