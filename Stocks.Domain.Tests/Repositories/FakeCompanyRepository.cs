using Stocks.Domain.Entities;
using Stocks.Domain.Enums;
using Stocks.Domain.Repositories;
using Stocks.Domain.ValueObjects;
using System;

namespace Stocks.Domain.Tests.Repositories
{
    public class FakeCompanyRepository : ICompanyRepository
    {
        public void Create(Company company)
        {
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
