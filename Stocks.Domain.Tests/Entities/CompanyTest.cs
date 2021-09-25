using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.ValueObjects;

namespace Stocks.Domain.Tests.Entities
{
    [TestClass]
    public class CompanyTest
    {
        [TestMethod]
        public void Create_new_company_active_should_be_true()
        {
            var company = new Company("APPLE", new Document("123456789", EDocumentType.CNPJ));

            Assert.AreEqual(true, company.Active);

        }
        
        [TestMethod]
        public void TurnActive_Active_Should_be_true()
        {
            var company = new Company("APPLE", new Document("123456789", EDocumentType.CNPJ));
            company.TurnActive();

            Assert.AreEqual(true, company.Active);

        }
        
        [TestMethod]
        public void TurnInactive_Active_Should_be_false()
        {
            var company = new Company("APPLE", new Document("123456789", EDocumentType.CNPJ));
            company.TurnInactive();

            Assert.AreEqual(false, company.Active);

        }
    }
}
