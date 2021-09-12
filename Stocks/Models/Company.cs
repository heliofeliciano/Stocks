using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models
{
    public class Company
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Nickname { get; set; }
        public string CNPJ { get; set; }
    }
}
