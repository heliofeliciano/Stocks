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

        public AlphaSymbol GetData()
        {
            var symbolOfStock = "AAPL";

            //Uri queryUri = new Uri($"https://www.alphavantage.co/query?function=EARNINGS&symbol={symbolOfStock}&apikey={API_KEY}");

            AlphaOverviewRequest alphaOverviewRequest = new AlphaOverviewRequest();
            Uri queryUri = alphaOverviewRequest.GetUrl(symbolOfStock);

            using (WebClient webClient = new WebClient())
            {

                string stringDownloadOfWebClient = webClient.DownloadString(queryUri);
                //dynamic json_data = JsonSerializer.Deserialize<AlphaEarnings>(stringDownloadOfWebClient);
                //dynamic json_data = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(stringDownloadOfWebClient);

                //string json = "{ \"symbol\": \"AAPL\", " +
                //    "\"annualEarnings\": [ { \"fiscalDateEnding\": \"2021-03-31\", \"reportedEPS\": \"3.08\" }], " +
                //    "\"quartelyEarnings\": [ { \"fiscalDateEnding\": \"2021-03-31\", \"reportedEPS\": \"3.08\" }]}";
                
                dynamic jsonserializer = JsonSerializer.Deserialize<AlphaSymbol>(stringDownloadOfWebClient);
                AlphaSymbol retorno = (AlphaSymbol)Convert.ChangeType(jsonserializer, typeof(AlphaSymbol));
                                
                return retorno;
            }
        }

    }

}
