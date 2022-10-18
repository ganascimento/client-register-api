using Client.Register.Domain.Entity;
using Client.Register.Infra.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Client.Register.Infra.Context;

public class DataContext : DbContext
{
    public DbSet<CustomerEntity>? Customer { get; set; }

    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CustomerEntity>(new CustomerMapping().Configure);
    }
}