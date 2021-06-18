using Stocks.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Data
{
    public class StatusInvestContextBDR : StatusInvestContextAbstract
    {
        public override string GetUrl()
        {
            return "https://statusinvest.com.br/bdrs";
        }

        private string PatternParity
        {
            get { return @"(\d)\sStock = (\d+)"; }
            set { PatternParity = value; }
        }

        public int GetParityMainStock(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatternParity);
            if (resultado.Count == 0)
            {
                return 0;
            }

            return Int32.Parse(resultado[0].Groups[1].Value);
        }

        public int GetParityStock(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatternParity);
            if (resultado.Count == 0)
            {
                return 0;
            }

            return Int32.Parse(resultado[0].Groups[2].Value);
        }
    }
}
