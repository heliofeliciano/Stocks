using Microsoft.AspNetCore.Mvc;
using Stocks.Domain.Commands.Stock;
using Stocks.Domain.Entities;
using Stocks.Domain.Handlers;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using System.Collections.Generic;

namespace Stocks.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/stocks")]
    public class StockController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<Stock> GetAll(
            [FromServices] IStockRepository repository
            )
        {
            return repository.GetAll();
        }
        
        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] CreateStockCommand command,
            [FromServices] StockHandler handler
            )
        {
            return (GenericCommandResult) handler.Handle(command);
        }
    }
}
