using Microsoft.EntityFrameworkCore;
using Stocks.Domain.Entities;
using Stocks.Domain.Infra.Contexts;
using Stocks.Domain.Queries;
using Stocks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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
            return _context
                .Companies
                .AsNoTracking()
                .OrderBy(x => x.Name);
        }

        public IEnumerable<Company> GetAllActive()
        {
            return _context
                .Companies
                .AsNoTracking()
                .Where(CompanyQueries.GetAllActive())
                .OrderBy(x => x.Name);
        }

        public IEnumerable<Company> GetAllInactive()
        {
            return _context
                .Companies
                .AsNoTracking()
                .Where(CompanyQueries.GetAllInactive())
                .OrderBy(x => x.Name);
        }

        public Company GetById(Guid id)
        {
            return _context
                .Companies
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Company company)
        {
            _context.Entry(company).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
