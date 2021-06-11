using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Libraries
{
    public static class StatusInvest
    {
        public static string PatternCurrentValueBDR 
        {
            get { return @"Valor atual<\/h3>\s<span class=\""icon\"">R.<\/span>\s<strong class=\""value\"">(\d+,\d+)<\/strong>"; }
            private set { PatternCurrentValueBDR = value;  }
        }
        public static string PatterParity
        {
            get { return @"(\d)\sStock = (\d+)"; }
            private set { PatterParity = value; }
        }

        public static string UrlBDR
        {
            get { return "https://statusinvest.com.br/bdrs"; }
            private set { UrlBDR = value; }
        }

        public static string getCurrentValue(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatternCurrentValueBDR);
            return resultado[0].Groups[1].Value;
        }
        
        public static string getParityMainStock(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatterParity);
            return resultado[0].Groups[1].Value;
        }
        
        public static string getParityBDRStock(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatterParity);
            return resultado[0].Groups[2].Value;
        }
    }
}
