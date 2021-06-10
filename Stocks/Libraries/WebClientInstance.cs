using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Stocks.Libraries
{
    public class WebClientInstance
    {
        private static WebClient webClientInstance;

        public WebClientInstance()
        {
        }

        public static WebClient GetWebClientInstance()
        {
            if (webClientInstance == null)
            {
                webClientInstance = new WebClient();
            }

            return webClientInstance;
        }

    }
}
