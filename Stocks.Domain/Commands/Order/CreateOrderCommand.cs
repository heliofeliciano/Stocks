using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Commands.Order
{
    public class CreateOrderCommand
    {
        public Guid BrokerId { get; set; }
        public Guid StockId { get; set; }
        public double Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Fees { get; set; }
        public string OrderType { get; set; }
    }
}
