using Flunt.Notifications;
using Stocks.Shared.Commands;
using System;

namespace Stocks.Domain.Commands.Stock
{
    public class ActivateStockCommand : Notifiable, ICommand
    {
        public ActivateStockCommand()
        {
        }
        public ActivateStockCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public void Validate()
        {
        }
    }
}
