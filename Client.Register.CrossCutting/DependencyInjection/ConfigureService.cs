using Client.Register.Domain.Service;
using Client.Register.Service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Client.Register.CrossCutting.DependencyInjection;

public static class ConfigureService
{
    public static void ConfigureDependenciesService(this IServiceCollection services)
    {
        services.AddScoped<ICustomerService, CustomerService>();
    }
}