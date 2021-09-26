using Stocks.Domain.Entities;
using Stocks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Infra.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        public void Create(Company company)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAllActive()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetAllInactive()
        {
            throw new NotImplementedException();
        }

        public Company GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
