using Flunt.Notifications;
using Stocks.Domain.Commands.Company;
using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using Stocks.Domain.ValueObjects;
using Stocks.Shared.Commands;
using Stocks.Shared.Handlers;

namespace Stocks.Domain.Handlers
{
    public class CompanyHandler : 
        Notifiable,
        IHandler<CreateCompanyCommand>,
        IHandler<TurnActiveCompanyCommand>,
        IHandler<TurnInactiveCompanyCommand>
    {
        private readonly ICompanyRepository _repository;

        public CompanyHandler(ICompanyRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateCompanyCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Opss, errors ocurred", command.Notifications);

            // create a company
            var company = new Company(command.Name, new Document(command.DocumentNumber, EDocumentType.CNPJ));

            // Save company in database
            _repository.Create(company);

            // Notifier user
            return new GenericCommandResult(true, "Company saved successfully!", company);
        }

        public ICommandResult Handle(TurnActiveCompanyCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Error", command.Notifications);

            var company = _repository.GetById(command.Id);

            company.TurnActive();

            _repository.Update(company);

            return new GenericCommandResult(true, "Company updated successfully", company);
        }

        public ICommandResult Handle(TurnInactiveCompanyCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Error", command.Notifications);

            var company = _repository.GetById(command.Id);

            company.TurnInactive();

            _repository.Update(company);

            return new GenericCommandResult(true, "Company updated successfully", company);
        }
    }
}
