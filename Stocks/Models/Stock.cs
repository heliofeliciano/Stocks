﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models
{
    public class Stock
    {
        public Guid Id { get; set; }
        public string Ticker { get; set; }
        public Company Company { get; set; }
    }
}
