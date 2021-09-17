using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.Company;
using Stocks.Domain.Handlers;
using Stocks.Domain.Shared;
using Stocks.Domain.Tests.Repositories;

namespace Stocks.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateCompanyHandlerTests
    {
        private readonly CreateCompanyCommand _invalidCommand = new CreateCompanyCommand("", "12345678912345");
        private readonly CreateCompanyCommand _validCommand = new CreateCompanyCommand("APPLE", "12345678912345");
        private readonly CompanyHandler _handler = new CompanyHandler(new FakeCompanyRepository());
        private GenericCommandResult _result = new GenericCommandResult();

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_execucao()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommand);
            Assert.AreEqual(_result.Success, false);
        }
        
        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_empresa()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.AreEqual(_result.Success, true);
        }
    }
}
