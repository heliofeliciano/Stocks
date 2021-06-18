using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Data
{
    public class StatusInvestContextStockBR : StatusInvestContextAbstract
    {
        public override string GetUrl()
        {
            return "https://statusinvest.com.br/acoes";
        }
    }
}
