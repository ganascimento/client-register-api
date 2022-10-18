using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Client.Register.Infra.Context;

public class ContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        //Usado para Criar as Migrações
        var connectionString = "Server=localhost;Database=test_guilherme;User Id=SA;Password=S&Nh4@123;";

        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseSqlServer(
            connectionString
        );

        return new DataContext(optionsBuilder.Options);
    }
}