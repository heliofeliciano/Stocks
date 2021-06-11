using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Stocks.Libraries
{
    public class HttpClientInstance
    {

        private string url;

        public HttpClientInstance(string urlrequest)
        {
            url = urlrequest;
        }

        public async Task<string> getStringAsync()
        {
            using var httpClient = new HttpClient();
            /*string resultado = await httpClient.GetStringAsync(url);*/

            return await httpClient.GetStringAsync(url);
        }
    }
}
