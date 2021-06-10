using Microsoft.AspNetCore.Mvc;
using Stocks.Libraries;
using Stocks.Models;
using System;
using System.Collections;
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
            StatusInvest statusInvestInstance = new StatusInvest();

            /*string[] companies = { "AAPL34", "AMZO34", "MELI34", "FBOK34", "BKNG34", "JDCO34", "SSFO34", "GOGL34" };*/
            string[] companies = { "MELI34" };

            var fonte = String.Empty;

            List<Stock> stockList = new List<Stock>();

            var resultado = new ArrayList();

            for (int i = 0; i < companies.Length; i++)
            {
                fonte = WebClientInstance.GetWebClientInstance().DownloadString($"https://statusinvest.com.br/bdrs/{companies[i]}");

                var rgxEncontrados2 = RegularExpresion.GetMatches(fonte, statusInvestInstance.PatternCurrentValue);
                var rgxEncontrados = RegularExpresion.GetMatches(fonte, statusInvestInstance.PatterParity); 

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

                resultado.Add(new
                {
                    Id = i+1,
                    Ticket = companies[i],
                    StockCurrentValue = stockCurrentValue,
                    Paridade = $"{paridadeAcaoPrincial} Stock = {paridadeAcaoBDR} BDR's"
                });

                /*stockList.Add(new Stock(companies[i], Double.Parse(stockCurrentValue), paridadeAcaoPrincial, paridadeAcaoBDR));*/
                /*stockList.Add(stock);*/
            }

            return Json(resultado);
        }
    }
}
