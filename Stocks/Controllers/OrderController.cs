using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Stocks.Data;
using Stocks.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Stocks.Controllers
{
    [Route("orders")]
    public class OrderController : Controller
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Order>>> Get([FromServices]DataContext context)
        {
            var orders = await context.Orders.AsNoTracking().ToListAsync();

            return Ok(orders);
        }
    }
}
