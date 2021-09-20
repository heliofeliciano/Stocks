using Flunt.Notifications;
using Flunt.Validations;
using Stocks.Shared.Commands;

namespace Stocks.Domain.Commands
{
    public class CreateStockCommand : Notifiable, ICommand
    {
        public CreateStockCommand()
        {
        }
        public CreateStockCommand(string companyName, string companyDocument, string ticker, string stockMarket)
        {
            CompanyName = companyName;
            CompanyDocument = companyDocument;
            Ticker = ticker;
            StockMarket = stockMarket;
        }

        public string CompanyName { get; set; }
        public string CompanyDocument { get; set; }
        public string Ticker { get; set; }
        public string StockMarket { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(CompanyName, "Company.Name", "Company Name is required")
                .IsNotNullOrEmpty(CompanyDocument, "Company.Document", "Company Document is required")
                .IsNotNullOrEmpty(StockMarket, "StockMarket", "Stock Market is required")
                .IsNotNullOrEmpty(Ticker, "Ticker", "Ticker is required")
                );
        }
    }
}
