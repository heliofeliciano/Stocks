using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Repositories;
using Stocks.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Stocks.Domain.Tests.Repositories
{
    public class FakeCompanyRepository : ICompanyRepository
    {
        private readonly List<Company> _items;

        public FakeCompanyRepository()
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

        public void Create(Company company)
        {
        }

        public IEnumerable<Company> GetAll()
        {
            return _items;
        }

        public IEnumerable<Company> GetAllActive()
        {
            return _items.Where(x => x.Active);
        }

        public IEnumerable<Company> GetAllInactive()
        {
            return _items.Where(x => x.Active == false);
        }

        public Company GetById(Guid id)
        {
            return new Company("APPLE", new Document("1234", EDocumentType.CNPJ));
        }

        public void Update(Company company)
        {
        }
    }
}
