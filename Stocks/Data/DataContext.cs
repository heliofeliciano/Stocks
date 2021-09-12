using Microsoft.EntityFrameworkCore;
using Stocks.Models;

namespace Stocks.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {

        }
        //public DbSet<StockEntity> Stocks { get; set; }
        //public DbSet<HomeMarketEntity> HomeMarkets { get; set; }
        //public DbSet<CompanyEntity> Companies { get; set; }
        //public DbSet<CountryEntity> Countries { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Company> Companies { get; set; }

    }
}
