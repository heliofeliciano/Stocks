using Flunt.Notifications;
using Stocks.Domain.Commands.Company;
using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using Stocks.Domain.ValueObjects;
using Stocks.Shared.Commands;
using Stocks.Shared.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Handlers
{
    public class CompanyHandler : 
        Notifiable,
        IHandler<CreateCompanyCommand>
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
                return new GenericCommandResult(false, "Opss, ocorred errors", command.Notifications);

            // create a company
            var company = new Company(command.Name, new Document(command.DocumentNumber, EDocumentType.CNPJ));

            // Save company in database
            _repository.Create(company);

            // Notifier user
            return new GenericCommandResult(true, "Company saved successfully!", company);
        }

    }
}
