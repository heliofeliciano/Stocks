﻿using Microsoft.AspNetCore.Mvc;
using Stocks.Data;
using Stocks.Libraries;
using Stocks.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
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
                Type = "PN",
                Company = new Company()
                {
                    Id = 1,
                    Name = "PETROBRAS",
                    DocumentNumber = "123456789",
                    Country = new Country()
                    {
                        Name = "Brazil",
                        Sigla = "BR"
                    }
                },
                HomeMarket = new HomeMarket()
                {
                    Id = 1,
                    Name = "B3"
                }
            };

            return Json(stock);
        }

        [HttpGet("InsertingData")]
        public void InsertingData()
        {
            var data = new DataContent();
            data.InsertingData();

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
            /*string[] companies = { "PETR4", "BBAS3", "VALE3", "BRAP4", "GUAR3", "EGIE3", "PETZ3", "SHUL4", "BRSR6", "COGN3", "MYPK3", "SUZB3", "BRPR3", "BPAC11", "ENBR3", "SEER3", "ITUB4", "ITSA4" };*/
            var type = "BDR";
            /*var type = "Acao";*/

            var fonte = String.Empty;

            List<Stock> stockList = new List<Stock>();

            var resultado = new ArrayList();

            for (int i = 0; i < companies.Length; i++)
            {
                fonte = WebClientInstance.GetWebClientInstance().DownloadString($"{StatusInvestContext.getUrl(type)}/{companies[i]}");

                var paridadeAcaoPrincial = StatusInvestContext.getParityMainStock(fonte);
                var paridadeAcaoBDR = StatusInvestContext.getParityBDRStock(fonte);
                var stockCurrentValue = StatusInvestContext.getCurrentValue(fonte);
                var stockCompanyName = StatusInvestContext.getCompanyName(fonte);
                var stockCompanyCNPJ = StatusInvestContext.getCompanyCNPJ(fonte);

                /*Stock stock = new Stock()
                {
                    Id = i,
                    Company = new Company()
                    {
                        Id = i,
                        Name = stockCompanyName,
                        CNPJ = stockCompanyCNPJ
                    },
                    Ticker = companies[i]
                };
                stockList.Add(stock);*/

                resultado.Add(new
                {
                    Id = i + 1,
                    Ticket = companies[i],
                    StockCurrentValue = stockCurrentValue,
                    CompanyCNPJ = stockCompanyCNPJ,
                    CompanyName = stockCompanyName,
                    Paridade = $"{paridadeAcaoPrincial} Stock = {paridadeAcaoBDR} BDR's"
                });


            }

            return Json(resultado);
        }
    }
}
