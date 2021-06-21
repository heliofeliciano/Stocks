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
        private string API_KEY = "F7CY0LUQ3YWQNP3K";

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

        public CashFlowAlpha GetCashFlowOfStock(Stock stock)
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

    }

}
