using Stocks.Models;
using Stocks.Models.Alpha;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace Stocks.Data
{
    public class AlphaVantageData
    {
        //private string API_KEY = "F7CY0LUQ3YWQNP3K";

        public EarningAlpha GetEarningData()
        {
            var symbolOfStock = "AAPL";

            EarningAlpha earningAlpha = new EarningAlpha();
            Uri earningUri = earningAlpha.GetUrl(symbolOfStock);

            using (WebClient webClient = new WebClient())
            {
                string stringDownloadOfWebClient = webClient.DownloadString(earningUri);
                                
                dynamic jsonserializer = JsonSerializer.Deserialize<EarningAlpha>(stringDownloadOfWebClient);
                EarningAlpha retorno = (EarningAlpha)Convert.ChangeType(jsonserializer, typeof(EarningAlpha));
                                
                return retorno;
            }
        }

        public CashFlowAlpha GetCashFlowOfStock(StockEntity stock)
        {
            CashFlowAlpha cashFlowAlpha = new CashFlowAlpha();
            Uri cashFlowUri = cashFlowAlpha.GetUrl(stock.Ticker);

            using (WebClient webClient = new WebClient())
            {
                string stringDownloadOfWebClient = webClient.DownloadString(cashFlowUri);

                dynamic jsonserializer = JsonSerializer.Deserialize<CashFlowAlpha>(stringDownloadOfWebClient);
                CashFlowAlpha retorno = (CashFlowAlpha)Convert.ChangeType(jsonserializer, typeof(CashFlowAlpha));

                return retorno;
            }
        }

        internal object GetTestYahooFinance(StockEntity stock)
        {
            DailyAdjustedAlpha dailyAlpha = new DailyAdjustedAlpha();
            Uri uriTest = new Uri("https://apidojo-yahoo-finance-v1.p.rapidapi.com/auto-complete?q=tesla&region=US");

            using (WebClient webClient = new WebClient())
            {
                webClient.Headers.Add("x-rapidapi-key", "41b1155247msh8d3b7bb9c529945p10d38cjsnaebdd19ad0b6");
                webClient.Headers.Add("x-rapidapi-host", "apidojo-yahoo-finance-v1.p.rapidapi.com");

                string stringDownloadOfWebClient = webClient.DownloadString(uriTest);
                
            }

            return "";
        }
    }

}
