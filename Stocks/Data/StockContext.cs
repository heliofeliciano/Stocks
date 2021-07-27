using Microsoft.EntityFrameworkCore;
using Stocks.Models;

namespace Stocks.Data
{
    public class StockContext : DbContext
    {
        public DbSet<StockEntity> Stocks { get; set; }
        public DbSet<HomeMarketEntity> HomeMarkets { get; set; }
        public DbSet<CompanyEntity> Companies { get; set; }
        public DbSet<CountryEntity> Countries { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=1234;Persist Security Info=True;User ID=sa;Initial Catalog=Stocks;Data Source=DESKTOP-JQE1K0H\\SQLEXPRESS");
        }
    }
}
