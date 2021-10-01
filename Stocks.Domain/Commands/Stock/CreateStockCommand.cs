using Flunt.Notifications;
using Flunt.Validations;
using Stocks.Shared.Commands;
using System;

namespace Stocks.Domain.Commands.Stock
{
    public class CreateStockCommand : Notifiable, ICommand
    {
        public CreateStockCommand()
        {
        }

        public CreateStockCommand(Guid companyId, string ticker, Guid stockMarketId)
        {
            CompanyId = companyId;
            Ticker = ticker;
            StockMarketId = stockMarketId;
        }

        //public CreateStockCommand(string companyName, string companyDocument, string ticker, string stockMarket)
        //{
        //    CompanyName = companyName;
        //    CompanyDocument = companyDocument;
        //    Ticker = ticker;
        //    StockMarket = stockMarket;
        //}

        public Guid CompanyId { get; set; }
        public string Ticker { get; set; }
        public Guid StockMarketId { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(CompanyId.ToString(), "Company.Id", "Company is required")
                .IsNotNullOrEmpty(StockMarketId.ToString(), "StockMarket.Id", "Stock Market is required")
                .IsNotNullOrEmpty(Ticker, "Ticker", "Ticker is required")
                .AreNotEquals(CompanyId.ToString(), "00000000-0000-0000-0000-000000000000", "Company.Id", "Company is not be empty")
                .AreNotEquals(StockMarketId.ToString(), "00000000-0000-0000-0000-000000000000", "StockMarket.Id", "StockMarket is not be empty")
                );
        }
    }
}
