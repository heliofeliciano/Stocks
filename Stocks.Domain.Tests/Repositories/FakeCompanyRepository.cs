using Stocks.Domain.Entities;
using Stocks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Tests.Repositories
{
    public class FakeCompanyRepository : ICompanyRepository
    {
        public void Create(Company company)
        {
        }

        public void Update(Company company)
        {
        }
    }
}
