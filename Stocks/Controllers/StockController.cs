using Microsoft.AspNetCore.Mvc;
using Stocks.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

namespace Stocks.Controllers
{
    [Route("api/[controller]")]
    public class StockController : Controller
    {
        public JsonResult Index()
        {
            Stock stock = new Stock()
            {
                Id = 1,
                Ticker = "PETR4",
                Type = "ON",
                Company = new Company()
                {
                    Id = 1,
                    Name = "PETROBRAS"
                },
                HomeMarket = new HomeMarket()
                {
                    Id = 1,
                    Name = "B3"
                }
            };

            return Json(stock);
        }

        [HttpGet("GetInfoStocks/")]
        public JsonResult GetInfoStocks()
        {
            WebClient wc = new WebClient();

            string[] companies = { "AAPL34", "AMZO34", "MELI34", "FBOK34", "BKNG34", "JDCO34", "SSFO34", "GOGL34" };

            var fonte = String.Empty;
            var patternCurrentValue = @"Valor atual<\/h3>\s<span class=\""icon\"">R.<\/span>\s<strong class=\""value\"">(\d+,\d+)<\/strong>";

            var patternParidade = @"(\d)\sStock = (\d+)";

            List<Stock> stockList = new List<Stock>();

            for (int i = 0; i < companies.Length; i++)
            {
                fonte = wc.DownloadString($"https://statusinvest.com.br/bdrs/{companies[i]}");

                var rgx2 = new Regex(patternCurrentValue);
                var rgxEncontrados2 = rgx2.Matches(fonte);

                var rgx = new Regex(patternParidade);
                var rgxEncontrados = rgx.Matches(fonte);

                int paridadeAcaoPrincial = Int32.Parse(rgxEncontrados[0].Groups[1].Value);
                int paridadeAcaoBDR = Int32.Parse(rgxEncontrados[0].Groups[2].Value);
                var stockCurrentValue = rgxEncontrados2[0].Groups[1].Value;

                Stock stock = new Stock()
                {
                    Id = i,
                    Company = new Company()
                    {
                        Id = i,
                        Name = companies[i]
                    },
                    Ticker = companies[i],
                    HomeMarket = new HomeMarket()
                    {
                        Id = 1,
                        Name = "NASDAQ"
                    }
                };

                /*stockList.Add(new Stock(companies[i], Double.Parse(stockCurrentValue), paridadeAcaoPrincial, paridadeAcaoBDR));*/
                stockList.Add(stock);
            }

            return Json(stockList);
        }
    }
}
