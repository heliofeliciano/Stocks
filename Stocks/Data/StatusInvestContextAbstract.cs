using Stocks.Libraries;
using System;
using System.Collections;

namespace Stocks.Data
{
    public abstract class StatusInvestContextAbstract
    {
        public abstract string GetUrl();
        public string GetCurrentValue(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, GetPatternCurrentValue());
            if (resultado.Count == 0)
            {
                return "Padrao nao encontrado";
            }

            return resultado[0].Groups[1].Value;
        }
        private string GetPatternCurrentValue()
        {
            return @"Valor atual<\/h3>\s<span class=\""icon\"">R.<\/span>\s<strong class=\""value\"">(\d+,\d+)<\/strong>";
        }
        private string GetPatternCompanyName()
        {
            return @"<small>([A-Z\s.]+)<\/small>";
        }
        public string GetCompanyName(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, GetPatternCompanyName());
            if (resultado.Count == 0)
            {
                return "Padrao nao encontrado";
            }

            return resultado[0].Groups[1].Value;
        }
        private string GetPatternCompanyCNPJ()
        {
            return @"([0-9]{2}[\.][0-9]{3}[\.][0-9]{3}[\/][0-9]{4}[-][0-9]{2})";
        }
        public string GetCompanyCNPJ(string content)
        {
            var resultado = RegularExpresion.GetMatches(content, GetPatternCompanyCNPJ());
            if (resultado.Count == 0)
            {
                return "Padrao nao encontrado";
            }

            return resultado[0].Groups[1].Value;
        }
        public string GetTypeOfStock(string ticketOfStock)
        {
            ArrayList companiesBDR = new ArrayList()
            {
                "AAPL34", "AMZO34", "MELI34", "FBOK34", "BKNG34", "JDCO34", "SSFO34", "GOGL34"
            };

            ArrayList companiesBR = new ArrayList()
            {
                "PETR4", "BBAS3", "VALE3", "BRAP4", "GUAR3", "EGIE3", "PETZ3", "SHUL4", "BRSR6", "COGN3", "MYPK3", "SUZB3", "BRPR3", "BPAC11", "ENBR3", "SEER3", "ITUB4", "ITSA4"
            };

            if (companiesBDR.Contains(ticketOfStock))
            {
                return "BDR";
            } else if (companiesBR.Contains(ticketOfStock))
            {
                return "AcaoBR";
            }
            return string.Empty;
        }
    }
}
