using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.Company;

namespace Stocks.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateCompanyCommandTests
    {
        private readonly CreateCompanyCommand _validCommand = new CreateCompanyCommand("APPLE", "12345678912345");
        private readonly CreateCompanyCommand _invalidCommand = new CreateCompanyCommand("", "12345678912345");
        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            _invalidCommand.Validate();

            Assert.AreEqual(false, _invalidCommand.Valid);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            _validCommand.Validate();

            Assert.AreEqual(true, _validCommand.Valid);
        }
    }
}
