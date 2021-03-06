using Flunt.Notifications;
using Flunt.Validations;
using Stocks.Shared.Commands;
using System;

namespace Stocks.Domain.Commands.Company
{
    public class TurnActiveCompanyCommand : Notifiable, ICommand
    {
        public TurnActiveCompanyCommand()
        {
        }
        public TurnActiveCompanyCommand(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .AreNotEquals(Id.ToString(), "00000000-0000-0000-0000-000000000000", "Company.Id", "Id is required"));
        }
    }
}
