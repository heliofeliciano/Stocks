using Microsoft.AspNetCore.Mvc;
using Stocks.Data;
using Stocks.Libraries;
using Stocks.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Stocks.Controllers
{
    [Route("api/[controller]")]
    public class StockController : Controller
    {
        public JsonResult Index()
        {
            StockEntity stock = new StockEntity()
            {
                Ticker = "PETR4",
                Company = new CompanyEntity()
                {
                    Name = "PETROBRAS",
                    DocumentNumber = "123456789",
                    Country = new CountryEntity()
                    {
                        Name = "Brazil",
                        Sigla = "BR"
                    }
                },
                HomeMarket = new HomeMarketEntity()
                {
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

        [HttpGet("GetAlphaVantageEarnings/")]
        public JsonResult GetAlphaVantageEarnings()
        {
            // APIKey F7CY0LUQ3YWQNP3K
            AlphaVantageData alpha = new AlphaVantageData();
            return Json(alpha.GetEarningData());

        }

        [HttpGet("GetAlphaVantageCashFlow/")]
        public JsonResult GetAlphaVantageCashFlow()
        {
            // APIKey F7CY0LUQ3YWQNP3K
            // 66.064.000.000
            AlphaVantageData alpha = new AlphaVantageData();
            return Json(alpha.GetCashFlowOfStock(new StockEntity()
            {
                Ticker = "AAPL"
            }));

        }

        [HttpGet("GetTestYahooFinance/")]
        public JsonResult GetTestYahooFinance()
        {
            // APIKey F7CY0LUQ3YWQNP3K
            // 66.064.000.000
            AlphaVantageData alpha = new AlphaVantageData();
            return Json(alpha.GetTestYahooFinance(new StockEntity()
            {
                Ticker = "AAPL"
            }));

        }

        /*
         * GetInfoStock
         * Responsável por buscar as informações em algum site
         */
        public void GetInfoAboutStock(StockEntity stock)
        {
            /*
             * Check if a stock is a bdr, stockbr or stockusd
             * 
             */
            var tickerOfStock = "AAPL34";

            var statusInvestContextBDR = new StatusInvestContextBDR();

            var fonte = WebClientInstance.GetWebClientInstance().DownloadString($"{statusInvestContextBDR.GetUrl()}/{tickerOfStock}");
            var paridadeAcaoPrincial = statusInvestContextBDR.GetParityMainStock(fonte);
            var paridadeAcaoBDR = statusInvestContextBDR.GetParityStock(fonte);
            var stockCurrentValue = statusInvestContextBDR.GetCurrentValue(fonte);
            var stockCompanyName = statusInvestContextBDR.GetCompanyName(fonte);
            var stockCompanyCNPJ = statusInvestContextBDR.GetCompanyCNPJ(fonte);

            var result = new
            {
                Id = 1,
                Ticket = tickerOfStock,
                StockCurrentValue = stockCurrentValue,
                CompanyCNPJ = stockCompanyCNPJ,
                CompanyName = stockCompanyName,
                Paridade = $"{paridadeAcaoPrincial} Stock = {paridadeAcaoBDR} BDR's"
            };
        } 
        
        private void GetInfoAboutStockBRL(StockEntity stock)
        {
            /*
             * Check if a stock is a bdr, stockbr or stockusd
             * 
             */
            //var tickerOfStock = "AAPL34";

            //var statusInvestContext = new StatusInvestContextStockBRL();

            //var fonte = WebClientInstance.GetWebClientInstance().DownloadString($"{statusInvestContext.GetUrl()}/{tickerOfStock}");
            //var paridadeAcaoPrincial = statusInvestContextBDR.GetParityMainStock(fonte);
            //var paridadeAcaoBDR = statusInvestContextBDR.GetParityStock(fonte);
            //var stockCurrentValue = statusInvestContextBDR.GetCurrentValue(fonte);
            //var stockCompanyName = statusInvestContextBDR.GetCompanyName(fonte);
            //var stockCompanyCNPJ = statusInvestContextBDR.GetCompanyCNPJ(fonte);

            //var result = new
            //{
            //    Id = 1,
            //    Ticket = tickerOfStock,
            //    StockCurrentValue = stockCurrentValue,
            //    CompanyCNPJ = stockCompanyCNPJ,
            //    CompanyName = stockCompanyName,
            //    Paridade = $"{paridadeAcaoPrincial} Stock = {paridadeAcaoBDR} BDR's"
            //};
        }

    }
}
