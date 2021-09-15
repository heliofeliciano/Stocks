using Flunt.Notifications;
using Flunt.Validations;
using Stocks.Shared.Commands;

namespace Stocks.Domain.Commands.Company
{
    public class CreateCompanyCommand : Notifiable, ICommand
    {
        public CreateCompanyCommand()
        {
        }

        public CreateCompanyCommand(string name, string documentNumber)
        {
            Name = name;
            DocumentNumber = documentNumber;
        }

        public string Name { get; set; }
        public string DocumentNumber { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Name, 3, "Company.Name", "Nome deve ter mais de 3 digitos")
            );
        }
    }
}
