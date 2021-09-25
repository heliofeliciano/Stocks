using Stocks.Domain.Entities;
using System;
using System.Linq.Expressions;

namespace Stocks.Domain.Queries
{
    public static class CompanyQueries
    {
        /*
         * O que é um delegate?
         * Delegate é a possibilidade de passar uma função como parametro de um método 
         * Delegate é a assinatura de um método
         *  
         * 
         * 
         */
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
        
    }
}
