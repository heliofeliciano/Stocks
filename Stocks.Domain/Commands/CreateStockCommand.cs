using Flunt.Notifications;
using Stocks.Shared.Commands;

namespace Stocks.Domain.Commands
{
    public class CreateStockCommand : Notifiable, ICommand
    {
        public string CompanyName { get; set; }
        public string CompanyDocument { get; private set; }
        public string Ticker { get; set; }
        public string StockMarket { get; set; }

        public void Validate()
        {
            // AddNotifications
        }
    }
}
