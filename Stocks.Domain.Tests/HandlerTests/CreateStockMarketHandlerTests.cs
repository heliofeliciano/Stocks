using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.StockMarket;
using Stocks.Domain.Handlers;
using Stocks.Domain.Shared;
using Stocks.Domain.Tests.Repositories;

namespace Stocks.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateStockMarketHandlerTests
    {
        [TestMethod]
        public void Dado_invalido_deve_para_execucao()
        {
            var stockMarketName = "";
            var command = new CreateStockMarketCommand(stockMarketName);

            var repository = new FakeStockMarketRepository();
            var handler = new StockMarketHandler(repository);
            var result = (GenericCommandResult)handler.Handle(command);

            Assert.AreEqual(false, result.Success);
        }
    }
}
