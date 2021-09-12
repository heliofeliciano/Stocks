using Stocks.Domain.Commands;
using Stocks.Domain.Entities;
using Stocks.Domain.Repositories;
using Stocks.Shared.Commands;
using Stocks.Shared.Handlers;
using System;

namespace Stocks.Domain.Handlers
{
    //public class OrderHandler : IHandler<CreateOrderBDRCommand>
    //{
    //    private readonly IOrderRepository _repositoryOrder;
    //    private readonly IStockRepository _repositoryStock;

    //    public OrderHandler(IOrderRepository repositoryOrder, IStockRepository repositoryStock)
    //    {
    //        _repositoryOrder = repositoryOrder;
    //        _repositoryStock = repositoryStock;
    //    }

    //    public ICommandResult Handle(CreateOrderBDRCommand command)
    //    {
    //        // What should TO DO here (flow)
    //        /*
    //         * 1 - Check if Stocks exists in database
    //         * 2 - Created a Order in database
    //         * 
    //         */

    //        // Generate entities
    //        var stock = _repositoryStock.GetStock(command.StockTicker);
    //        var order = new _OrderB3(stock, DateTime.UtcNow, command.Amount, command.Price, command.Fees);

    //        // Salvar informações
    //        _repositoryOrder.CreateOrderInB3(order);

    //        return new CommandResult(true, "Order created successfully");
    //    }
    //}
}
