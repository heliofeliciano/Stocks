using Flunt.Notifications;
using Stocks.Shared.Commands;
using System;

namespace Stocks.Domain.Commands.Stock
{
    public class InactivateStockCommand : Notifiable, ICommand
    {
        public InactivateStockCommand()
        {
        }
        public InactivateStockCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public void Validate()
        {
        }
    }
}
