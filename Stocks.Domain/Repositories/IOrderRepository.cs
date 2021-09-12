using Stocks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Repositories
{
    public interface IOrderRepository
    {
        bool StockExists();
    }
}
