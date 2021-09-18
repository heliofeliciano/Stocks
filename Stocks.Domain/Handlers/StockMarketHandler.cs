using Flunt.Notifications;
using Stocks.Domain.Commands;
using Stocks.Domain.Entities;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using Stocks.Shared.Commands;
using Stocks.Shared.Handlers;

namespace Stocks.Domain.Handlers
{
    public class StockMarketHandler : 
        Notifiable,
        IHandler<CreateStockMarketCommand>
    {
        private readonly IStockMarketRepository _stockMarketRepository;

        public StockMarketHandler(IStockMarketRepository stockMarketRepository)
        {
            _stockMarketRepository = stockMarketRepository;
        }

        public ICommandResult Handle(CreateStockMarketCommand command)
        {
            // Fail fast validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Opss, errors occurred", command.Notifications);

            // Create a StockMarket
            var stockMarket = new StockMarket(command.Name);

            // Save StockMarket in database
            _stockMarketRepository.Create(stockMarket);

            // Notifier user
            return new GenericCommandResult(true, "StockMarket saved successfully!", stockMarket);
        }
    }
}
