using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stocks.Models.Alpha
{
    public abstract class AlphaRequest
    {
        public abstract string FunctionName { get;  }

        private string API_KEY = "F7CY0LUQ3YWQNP3K";
    
        public Uri GetUrl(string symbolOfStock)
        {
            Uri queryFullUri = new Uri($"https://www.alphavantage.co/query?function={FunctionName}&symbol={symbolOfStock}&apikey={API_KEY}");
            return queryFullUri;
        }
    }
}
