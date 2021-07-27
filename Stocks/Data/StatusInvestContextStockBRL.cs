namespace Stocks.Data
{
    public class StatusInvestContextStockBRL : StatusInvestContextAbstract
    {
        public override string GetUrl()
        {
            return "https://statusinvest.com.br/acoes";
        }
    }
}
