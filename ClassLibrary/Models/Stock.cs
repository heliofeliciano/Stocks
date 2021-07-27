using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Models
{
    public class Stock
    {
        public Guid Id { get; set; }
        public string Ticker { get; set; }
        public Company Company { get; set; }
    }
}
