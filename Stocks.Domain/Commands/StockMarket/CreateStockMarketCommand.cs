using Flunt.Notifications;
using Flunt.Validations;
using Stocks.Shared.Commands;

namespace Stocks.Domain.Commands.StockMarket
{
    public class CreateStockMarketCommand : Notifiable, ICommand
    {
        public CreateStockMarketCommand()
        {
        }
        public CreateStockMarketCommand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Name, "StockMarket.Name", "Nome deve ser preenchido"));
        }
    }
}
