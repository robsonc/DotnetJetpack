using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using DotnetJetpack.Core.Domain.Interfaces;
using DotnetJetpack.Infrastructure.Data;
//using DotnetJetpack.Infrastructure.Repositories;

namespace DotnetJetpack.Infrastructure.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // Infra - Data
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            // Infra - Repositories
            //services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
