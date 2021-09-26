using Microsoft.EntityFrameworkCore;
using Stocks.Domain.Entities;
using Stocks.Domain.Infra.Contexts;
using Stocks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stocks.Domain.Infra.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly DataContext _context;

        public CompanyRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
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
            _context.Entry(company).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
