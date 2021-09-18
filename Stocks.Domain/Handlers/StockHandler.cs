using Flunt.Notifications;
using Stocks.Domain.Commands;
using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using Stocks.Domain.ValueObjects;
using Stocks.Shared.Commands;
using Stocks.Shared.Handlers;

namespace Stocks.Domain.Handlers
{
    public class StockHandler :
        Notifiable,
        IHandler<CreateStockCommand>
    {
        private readonly IStockRepository _stockRepository;

        public StockHandler(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public ICommandResult Handle(CreateStockCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ooppss, Errors Occurred", command.Notifications);

            // Create Stock Object
            var company = new Company(command.CompanyName, new Document(command.CompanyDocument, EDocumentType.CNPJ));
            var stockMarket = new StockMarket(command.StockMarket);
            var stock = new Stock(company, command.Ticker, stockMarket);

            // Save in database
            _stockRepository.Create(stock);

            // Return message to user
            return new GenericCommandResult(true, "Saved sucessfully", stock);
        }
    }
}
