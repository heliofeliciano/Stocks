using Microsoft.AspNetCore.Mvc;
using Stocks.Domain.Commands.Company;
using Stocks.Domain.Entities;
using Stocks.Domain.Handlers;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using System.Collections.Generic;

namespace Stocks.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/companies")]
    public class CompanyController : Controller
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Company> GetAll(
            [FromServices] ICompanyRepository repository
            )
        {
            return repository.GetAll();
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] CreateCompanyCommand command,
            [FromServices] CompanyHandler handler
            )
        {
            // Command
            // Handler
            //command.Name = "APPLE";
            //command.DocumentNumber = "12345";

            return (GenericCommandResult) handler.Handle(command);
        }
    }
}
