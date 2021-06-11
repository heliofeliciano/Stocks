using Microsoft.AspNetCore.Mvc;
using Stocks.Libraries;
using Stocks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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

        [HttpGet("GetStockHttpClient/")]
        public async Task<JsonResult> GetStockHttpClient()
        {
            HttpClient httpClient = new HttpClient();
            var result = await httpClient.GetStringAsync($"https://statusinvest.com.br/bdrs/MELI34");

            return Json(result);
        }

        [HttpGet("GetInfoStocks/")]
        public JsonResult GetInfoStocks()
        {
            string[] companies = { "AAPL34", "AMZO34", "MELI34", "FBOK34", "BKNG34", "JDCO34", "SSFO34", "GOGL34" };
            /*string[] companies = { "MELI34" };*/

            var fonte = String.Empty;

            List<Stock> stockList = new List<Stock>();

            var resultado = new ArrayList();

            for (int i = 0; i < companies.Length; i++)
            {
                fonte = WebClientInstance.GetWebClientInstance().DownloadString($"{StatusInvest.UrlBDR}/{companies[i]}");

                int paridadeAcaoPrincial = Int32.Parse(StatusInvest.getParityMainStock(fonte));
                int paridadeAcaoBDR = Int32.Parse(StatusInvest.getParityBDRStock(fonte));
                var stockCurrentValue = StatusInvest.getCurrentValue(fonte);

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
