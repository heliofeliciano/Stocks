using Microsoft.EntityFrameworkCore;
using Stocks.Domain.Entities;

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
            modelBuilder.Entity<Company>().Property(x => x.Document).HasColumnType("varchar(14)");
        }
    }
}
