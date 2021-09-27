using Stocks.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Stocks.Domain.Queries
{
    public static class CompanyQueries
    {
        public static Expression<Func<Company, bool>> GetAll()
        {
            return x => x.Id != null;
        }
        
        public static Expression<Func<Company, bool>> GetAllActive()
        {
            return x => x.Id != null && x.Active == true;
        }
        
        public static Expression<Func<Company, bool>> GetAllInactive()
        {
            return x => x.Id != null && x.Active == false;
        }

        public static Expression<Func<Company, bool>> GetById(Guid id)
        { 
            return x => x.Id == id;
        }
        
    }
}
