using Flunt.Notifications;
using Flunt.Validations;
using Stocks.Shared.Commands;
using System;

namespace Stocks.Domain.Commands.Company
{
    public class UpdateCompanyCommand : Notifiable, ICommand
    {
        public UpdateCompanyCommand()
        {
        }
        public UpdateCompanyCommand(Guid id, string name, string documentNumber)
        {
            Id = id;
            Name = name;
            DocumentNumber = documentNumber;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DocumentNumber { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Name, 3, "Company.Name", "Nome deve ter mais de 3 digitos")
                );
        }
    }
}
