using Flunt.Notifications;
using Flunt.Validations;
using Stocks.Shared.Commands;

namespace Stocks.Domain.Commands.Broker
{
    public class CreateBrokerCommand : Notifiable, ICommand
    {
        public CreateBrokerCommand(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .IsNotNullOrEmpty(Name, "Broker.Name", "Name shouldn't be empty"));
        }
    }
}
