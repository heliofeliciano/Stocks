using Flunt.Notifications;
using Stocks.Shared.Commands;

namespace Stocks.Domain.Commands
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
            if (Name.Length < 4) 
                
        }
    }
}
