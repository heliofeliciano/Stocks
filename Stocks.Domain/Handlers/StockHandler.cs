using Flunt.Notifications;
using Stocks.Domain.Commands.Stock;
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
        IHandler<CreateStockCommand>,
        IHandler<UpdateTickerCommand>,
        IHandler<ActivateStockCommand>,
        IHandler<InactivateStockCommand>
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

        public ICommandResult Handle(UpdateTickerCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Don't updated Stock", command.Notifications);

            // Recovered a StockId
            var stock = _stockRepository.GetById(command.Id);

            // Update ticker
            stock.UpdateTicker(command.Ticker);

            // Save database
            _stockRepository.Update(stock);

            // Return result
            return new GenericCommandResult(true, "Stock updated sucessfully", stock);
        }

        public ICommandResult Handle(ActivateStockCommand command)
        {
            // Fail fast validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Error", command.Notifications);

            // Recovered a StockId
            var stock = _stockRepository.GetById(command.Id);

            // Activate stock
            stock.ActivateStock();

            // save in database
            _stockRepository.Update(stock);

            // return result
            return new GenericCommandResult(true, "Stock updated sucessfully", stock);

        }

        public ICommandResult Handle(InactivateStockCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Error", command.Notifications);

            var stock = _stockRepository.GetById(command.Id);

            stock.InactivateStock();

            _stockRepository.Update(stock);

            return new GenericCommandResult(true, "Stock updated sucessfully", stock);
        }
    }
}
