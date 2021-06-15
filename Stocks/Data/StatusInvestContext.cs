using Stocks.Libraries;
using System;

namespace Stocks.Data
{
    public static class StatusInvestContext
    {
        private static string PatternCurrentValueBDR 
        {
            get { return @"Valor atual<\/h3>\s<span class=\""icon\"">R.<\/span>\s<strong class=\""value\"">(\d+,\d+)<\/strong>"; }
            set { PatternCurrentValueBDR = value;  }
        }
        private static string PatternParity
        {
            get { return @"(\d)\sStock = (\d+)"; }
            set { PatternParity = value; }
        }

        private static string PatternCompanyName
        {
            get { return @"<small>([A-Z\s.]+)<\/small>"; }
            set { PatternCompanyName= value; }
        }
        
        private static string PatternCompanyCNPJ
        {
            get { return @"([0-9]{2}[\.][0-9]{3}[\.][0-9]{3}[\/][0-9]{4}[-][0-9]{2})"; }
            set { PatternCompanyCNPJ = value; }
        }

        private static string UrlBDR
        {
            get { return "https://statusinvest.com.br/bdrs"; }
            set { UrlBDR = value; }
        }
        
        private static string UrlAcao
        {
            get { return "https://statusinvest.com.br/acoes"; }
            set { UrlAcao = value; }
        }

        public static string getUrl(string type)
        {
            if (type == "BDR")
            {
                return UrlBDR;
            } else if(type == "Acao")
            {
                return UrlAcao;
            }

            return String.Empty;
        }
        
        public static string getCurrentValue(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatternCurrentValueBDR);
            if (resultado.Count == 0)
            {
                return "Padrao nao encontrado";
            }

            return resultado[0].Groups[1].Value;
        }
        
        public static int getParityMainStock(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatternParity);
            if (resultado.Count == 0)
            {
                return 0;
            }

            return Int32.Parse(resultado[0].Groups[1].Value);
        }
        
        public static int getParityBDRStock(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatternParity);
            if (resultado.Count == 0)
            {
                return 0;
            }

            return Int32.Parse(resultado[0].Groups[2].Value);
        }
        
        public static string getCompanyName(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatternCompanyName);
            if (resultado.Count == 0)
            {
                return "Padrao nao encontrado";
            }

            return resultado[0].Groups[1].Value;
        }
        
        public static string getCompanyCNPJ(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, PatternCompanyCNPJ);
            if (resultado.Count == 0)
            {
                return "Padrao nao encontrado";
            }

            return resultado[0].Groups[1].Value;
        }
    }
}
