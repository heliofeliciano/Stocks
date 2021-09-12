using Stocks.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Repositories
{
    public interface ICompanyRepository
    {
        void CreateCompany(Company company);

        bool CheckExists(string numberDocument);
    }
}
