using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Queries;
using Stocks.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stocks.Domain.Tests.Queries
{
    [TestClass]
    public class CompanyQueriesTests
    {
        private List<Company> _items;

        public CompanyQueriesTests()
        {
            _items = new List<Company>();
            var company01 = new Company("APPLE", new Document("123", EDocumentType.CNPJ));
            var company02 = new Company("APPLE", new Document("123", EDocumentType.CNPJ));
            var company03 = new Company("APPLE", new Document("123", EDocumentType.CNPJ));
            var company04 = new Company("APPLE", new Document("123", EDocumentType.CNPJ));
            var company05 = new Company("APPLE", new Document("123", EDocumentType.CNPJ));
            company01.TurnInactive();
            company03.TurnInactive();
            company04.TurnInactive();

            _items.Add(company01);
            _items.Add(company02);
            _items.Add(company03);
            _items.Add(company04);
            _items.Add(company05);
        }

        [TestMethod]
        public void Dado_a_consulta_deve_retornar_companies_apenas_ativas()
        {
            var result = _items.AsQueryable().Where(CompanyQueries.GetAllActive());
            Assert.AreEqual(2, result.Count());
        } 
        
        [TestMethod]
        public void Dado_a_consulta_deve_retornar_companies_apenas_inativas()
        {
            var result = _items.AsQueryable().Where(CompanyQueries.GetAllInactive());
            Assert.AreEqual(3, result.Count());
        }

        [TestMethod]
        public void Dado_um_novo_guid_lista_deve_conter_zero_elementos()
        {
            var id = Guid.NewGuid();

            var result = _items.AsQueryable().Where(CompanyQueries.GetById(id));

            Assert.AreEqual(0, result.Count());
        }
    }
}
