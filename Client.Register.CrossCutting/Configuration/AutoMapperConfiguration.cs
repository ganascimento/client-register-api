using AutoMapper;
using Client.Register.CrossCutting.Mapping;
using Microsoft.Extensions.DependencyInjection;

namespace Client.Register.CrossCutting.Configuration;

public static class AutoMapperConfiguration
{
    public static void ConfigureAutoMapper(this IServiceCollection services)
    {
        var autoMapperConfig = new AutoMapper.MapperConfiguration(config =>
        {
            config.AddProfile(new CustumerMapping());
        });

        IMapper mapper = autoMapperConfig.CreateMapper();
        services.AddSingleton(mapper);
    }
}