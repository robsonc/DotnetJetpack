using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DotnetJetpack.Core.Configuration;

public static class DependencyInjection
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        // MediatR
        services.AddMediatR(config =>
        {
            config.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
        });

        return services;
    }
}
