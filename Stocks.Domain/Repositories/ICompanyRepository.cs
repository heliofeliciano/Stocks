using Stocks.Domain.Entities;

namespace Stocks.Domain.Repositories
{
    public interface ICompanyRepository
    {
        void Create(Company company);
        void Update(Company company);
    }
}
