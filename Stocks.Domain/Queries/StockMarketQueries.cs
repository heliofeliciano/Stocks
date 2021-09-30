using Stocks.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Stocks.Domain.Queries
{
    public class StockMarketQueries
    {
        public static Expression<Func<StockMarket, bool>> GetAll()
        {
            return x => x.Id != null;
        }

        public static Expression<Func<StockMarket, bool>> GetAllActive()
        {
            return x => x.Id != null; /* && x.Active == true;*/
        }

        public static Expression<Func<StockMarket, bool>> GetAllInactive()
        {
            return x => x.Id != null; /* && x.Active == false;*/
        }

        public static Expression<Func<StockMarket, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}
