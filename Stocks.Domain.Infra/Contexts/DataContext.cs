using Microsoft.EntityFrameworkCore;
using Stocks.Domain.Entities;
using Stocks.Domain.ValueObjects;

namespace Stocks.Domain.Infra.Contexts
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Company> Companies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>().ToTable("Company");
            modelBuilder.Entity<Company>().Property(x => x.Id);
            modelBuilder.Entity<Company>().Property(x => x.Name).HasMaxLength(200);
            modelBuilder.Entity<Company>().Property(x => x.Document)
                .HasConversion(a => a.Number,
                               s => new Document(s))
                .HasColumnType("varchar(14)");
            
            modelBuilder.Entity<StockMarket>().ToTable("StockMarket");
            modelBuilder.Entity<StockMarket>().Property(x => x.Id);
            modelBuilder.Entity<StockMarket>().Property(x => x.Name);
            
            modelBuilder.Entity<Stock>().ToTable("Stock");
            modelBuilder.Entity<Stock>().Property(x => x.Id);
            modelBuilder.Entity<Stock>().Property(x => x.Ticker);
            modelBuilder.Entity<Stock>().Property(x => x.Active).HasColumnType("bit");
            modelBuilder.Entity<Stock>().HasOne(x => x.Company);
            modelBuilder.Entity<Stock>().HasOne(x => x.StockMarket);
        }
    }
}
