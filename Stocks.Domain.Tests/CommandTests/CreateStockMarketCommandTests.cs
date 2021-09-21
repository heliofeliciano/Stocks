using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.StockMarket;

namespace Stocks.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateStockMarketCommandTests
    {
        private readonly CreateStockMarketCommand _validCommand = new CreateStockMarketCommand("B3");
        private readonly CreateStockMarketCommand _invalidCommand = new CreateStockMarketCommand("");

        [TestMethod]
        public void Dado_name_invalido_deve_retornar_invalido()
        {
            _invalidCommand.Validate();

            Assert.AreEqual(false, _invalidCommand.Valid);
        }
        
        [TestMethod]
        public void Dado_name_valido_deve_retornar_valido()
        {
            _validCommand.Validate();

            Assert.AreEqual(true, _validCommand.Valid);
        }
    }
}
