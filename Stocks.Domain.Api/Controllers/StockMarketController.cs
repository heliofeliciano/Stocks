using Microsoft.AspNetCore.Mvc;
using Stocks.Domain.Commands.StockMarket;
using Stocks.Domain.Entities;
using Stocks.Domain.Handlers;
using Stocks.Domain.Repositories;
using Stocks.Domain.Shared;
using System.Collections.Generic;

namespace Stocks.Domain.Api.Controllers
{
    [ApiController]
    [Route("v1/stockmarkets")]
    public class StockMarketController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IEnumerable<StockMarket> GetAll(
            [FromServices] IStockMarketRepository repository
            )
        {
            return repository.GetAll();
        }

        [HttpPost]
        [Route("")]
        public GenericCommandResult Create(
            [FromBody] CreateStockMarketCommand command,
            [FromServices] StockMarketHandler handler
            )
        {
            return (GenericCommandResult) handler.Handle(command);

        }

    }
}
