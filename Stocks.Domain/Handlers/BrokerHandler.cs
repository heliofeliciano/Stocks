using Stocks.Domain.Commands.Broker;
using Stocks.Domain.Entities;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using Stocks.Shared.Commands;
using Stocks.Shared.Handlers;

namespace Stocks.Domain.Handlers
{
    public class BrokerHandler : IHandler<CreateBrokerCommand>
    {
        private readonly IBrokerRepository _brokerRepository;

        public BrokerHandler(IBrokerRepository brokerRepository)
        {
            _brokerRepository = brokerRepository;
        }

        public ICommandResult Handle(CreateBrokerCommand command)
        {
            // Fail fast validations
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Errors ocorrs", command.Notifications);

            // Object
            var broker = new Broker(command.Name);

            // Save
            _brokerRepository.Create(broker);

            // Return
            return new GenericCommandResult(true, "Saved sucessfully", broker);
        }
    }
}
