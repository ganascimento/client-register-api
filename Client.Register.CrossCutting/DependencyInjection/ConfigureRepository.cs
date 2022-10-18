using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Client.Register.Domain.Repository;
using Client.Register.Infra.Repository;
using Client.Register.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace Client.Register.CrossCutting.DependencyInjection;

public static class ConfigureRepository
{
    public static void ConfigureDependenciesRepository(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddScoped<ICustomerRepository, CustomerRepository>();

        services.AddDbContext<DataContext>(
            options => options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")
            )
        );
    }
}