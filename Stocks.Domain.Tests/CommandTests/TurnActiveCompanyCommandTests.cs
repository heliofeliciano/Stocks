using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.Company;
using System;

namespace Stocks.Domain.Tests.CommandTests
{
    [TestClass]
    public class TurnActiveCompanyCommandTests
    {
        private readonly TurnActiveCompanyCommand _validCommand = new TurnActiveCompanyCommand(Guid.NewGuid());
        private readonly TurnActiveCompanyCommand _invalidCommand = new TurnActiveCompanyCommand();

        [TestMethod]
        public void Entry_With_Datas_invalid_command_has_invalid()
        {
            _invalidCommand.Validate();

            Assert.AreEqual(false, _invalidCommand.Valid);
        }

        [TestMethod]
        public void Entry_With_Datas_valid_command_has_valid()
        {

            _validCommand.Validate();

            Assert.AreEqual(true, _validCommand.Valid);
        }
    }
}
