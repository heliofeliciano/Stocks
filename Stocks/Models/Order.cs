using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public Company Company { get; set; }
        public float Amount { get; set; }
        public Decimal Price { get; set; }
        public Decimal Fees { get; set; }
    }
}
