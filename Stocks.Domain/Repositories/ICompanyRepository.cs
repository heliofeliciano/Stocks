using Stocks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Stocks.Domain.Repositories
{
    public interface ICompanyRepository
    {
        void Create(Company company);
        void Update(Company company);
        Company GetById(Guid id);

        IEnumerable<Company> GetAll();
        IEnumerable<Company> GetAllActive();
        IEnumerable<Company> GetAllInactive();
    }
}
