﻿using System;

namespace Stocks.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }
        public Country Country { get; set; }
        public string toValidDocumentNumber()
        {
            return string.Empty;
        }
    }
}
