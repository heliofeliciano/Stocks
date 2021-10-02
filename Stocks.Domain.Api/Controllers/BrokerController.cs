using Microsoft.AspNetCore.Mvc;
using Stocks.Domain.Commands.Broker;
using Stocks.Domain.Entities;
using Stocks.Domain.Handlers;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using System.Collections.Generic;

namespace Stocks.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/brokers")]
    public class BrokerController : Controller
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<Broker> GetAll([FromServices] IBrokerRepository repository)
        {
            return repository.GetAll();
        }
        
        [HttpPost]
        [Route("")]
        public GenericCommandResult Create(
            [FromBody] CreateBrokerCommand command,
            [FromServices] BrokerHandler handler
         )
        {
            return (GenericCommandResult) handler.Handle(command);
        }
    }
}
