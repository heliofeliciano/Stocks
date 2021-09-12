using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ClassLibrary.Instances
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
