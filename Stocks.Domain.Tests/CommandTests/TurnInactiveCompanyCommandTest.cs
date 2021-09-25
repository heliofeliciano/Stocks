using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Commands.Company;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Tests.CommandTests
{
    [TestClass]
    public class TurnInactiveCompanyCommandTest
    {
        private readonly TurnInactiveCompanyCommand _validCommand = new TurnInactiveCompanyCommand(Guid.NewGuid());
        private readonly TurnInactiveCompanyCommand _invalidCommand = new TurnInactiveCompanyCommand();

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
