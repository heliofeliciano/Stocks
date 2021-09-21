using Flunt.Notifications;
using Flunt.Validations;
using Stocks.Shared.Commands;
using System;

namespace Stocks.Domain.Commands.Stock
{
    public class UpdateTickerCommand : Notifiable, ICommand
    {
        public UpdateTickerCommand()
        {
        }
        public UpdateTickerCommand(Guid id, string companyName, string companyDocument, string ticker, string stockMarket)
        {
            Id = id;
            CompanyName = companyName;
            CompanyDocument = companyDocument;
            Ticker = ticker;
            StockMarket = stockMarket;
        }

        public Guid Id { get; set; }
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
