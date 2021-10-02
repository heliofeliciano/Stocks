using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.Broker;
using Stocks.Domain.Handlers;
using Stocks.Domain.Tests.Repositories;

namespace Stocks.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateBrokerHandlerTest
    {
        [TestMethod]
        public void Dado_um_name_invalido_deve_retornar_invalido()
        {
            //var repository = new FakeBrokerRepository();
            //var handler = new BrokerHandler(repository);
            var command = new CreateBrokerCommand("");
            command.Validate();

            Assert.AreEqual(false, command.Valid);
        }
        
        [TestMethod]
        public void Dado_um_name_valido_deve_retornar_valido()
        {
            var command = new CreateBrokerCommand("MIRAE ASSET");
            command.Validate();

            Assert.AreEqual(true, command.Valid);
        }
    }
}
