using Stocks.Domain.Commands;
using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Repositories;
using Stocks.Domain.ValueObjects;
using Stocks.Shared.Commands;
using Stocks.Shared.Handlers;

namespace Stocks.Domain.Handlers
{
    //public class CompanyHandler : IHandler<CreateCompanyCommand>
    //{
    //    public readonly ICompanyRepository _companyRepository;
    //    public CompanyHandler(ICompanyRepository companyRepository)
    //    {
    //        _companyRepository = companyRepository;
    //    }

    //    public ICommandResult Handle(CreateCompanyCommand command)
    //    {
    //        // Check if document is registered
    //        if (_companyRepository.CheckExists(command.DocumentNumber))
    //        {
    //            return new CommandResult(false, "Document already registered.");
    //        }

    //        // Generate VOs
    //        var document = new Document(command.DocumentNumber, EDocumentType.CNPJ);

    //        // Generate Entities
    //        var company = new Company(command.Name, document);

    //        // Save information
    //        _companyRepository.CreateCompany(company);

    //        return new CommandResult(true, "Company registered successfully.");
    //    }
    //}
}
