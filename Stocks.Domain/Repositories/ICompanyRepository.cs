using Stocks.Domain.Entities;
using System;

namespace Stocks.Domain.Repositories
{
    public interface ICompanyRepository
    {
        void Create(Company company);
        void Update(Company company);
        Company GetById(Guid id);
    }
}
