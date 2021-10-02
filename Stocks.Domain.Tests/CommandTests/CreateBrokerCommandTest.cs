using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.Broker;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateBrokerCommandTest
    {
        [TestMethod]
        public void Dado_um_name_deve_retornar_valido()
        {
            var command = new CreateBrokerCommand("MIRAE ASSET");
            command.Validate();

            Assert.AreEqual(true, command.Valid);
        }
        
        [TestMethod]
        public void Dado_um_name_invalido_deve_retornar_invalido()
        {
            var command = new CreateBrokerCommand("");
            command.Validate();

            Assert.AreEqual(false, command.Valid);
        }
    }
}
