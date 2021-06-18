using Stocks.Libraries;
using System;

namespace Stocks.Data
{
    public class StatusInvestContext
    {
        //private string PatternCompanyName
        //{
        //    get { return @"<small>([A-Z\s.]+)<\/small>"; }
        //    set { PatternCompanyName= value; }
        //}
        
        //private string PatternCompanyCNPJ
        //{
        //    get { return @"([0-9]{2}[\.][0-9]{3}[\.][0-9]{3}[\/][0-9]{4}[-][0-9]{2})"; }
        //    set { PatternCompanyCNPJ = value; }
        //}

        //private string PatternCurrentValueBDR
        //{
        //    get { return @"Valor atual<\/h3>\s<span class=\""icon\"">R.<\/span>\s<strong class=\""value\"">(\d+,\d+)<\/strong>"; }
        //    set { PatternCurrentValueBDR = value; }
        //}

        //private string PatternParity
        //{
        //    get { return @"(\d)\sStock = (\d+)"; }
        //    set { PatternParity = value; }
        //}

        
        //public string getUrl(string type)
        //{
        //    if (type == "BDR")
        //    {
        //        return UrlBDR;
        //    } else if(type == "Acao")
        //    {
        //        return Url;
        //    }

        //    return String.Empty;
        //}
        
        //public string getCurrentValue(string content)
        //{
        //    var resultado = RegularExpresion.GetMatches(content, PatternCurrentValueBDR);
        //    if (resultado.Count == 0)
        //    {
        //        return "Padrao nao encontrado";
        //    }

        //    return resultado[0].Groups[1].Value;
        //}
        
        //public int getParityMainStock(string content)
        //{
        //    var resultado = RegularExpresion.GetMatches(content, PatternParity);
        //    if (resultado.Count == 0)
        //    {
        //        return 0;
        //    }

        //    return Int32.Parse(resultado[0].Groups[1].Value);
        //}
        
        //public int getParityBDRStock(string content)
        //{
        //    var resultado = RegularExpresion.GetMatches(content, PatternParity);
        //    if (resultado.Count == 0)
        //    {
        //        return 0;
        //    }

        //    return Int32.Parse(resultado[0].Groups[2].Value);
        //}
        
        //public string getCompanyName(string content)
        //{
        //    var resultado = RegularExpresion.GetMatches(content, PatternCompanyName);
        //    if (resultado.Count == 0)
        //    {
        //        return "Padrao nao encontrado";
        //    }

        //    return resultado[0].Groups[1].Value;
        //}
        
        //public string getCompanyCNPJ(string content)
        //{
        //    var resultado = RegularExpresion.GetMatches(content, PatternCompanyCNPJ);
        //    if (resultado.Count == 0)
        //    {
        //        return "Padrao nao encontrado";
        //    }

        //    return resultado[0].Groups[1].Value;
        //}
    }
}
