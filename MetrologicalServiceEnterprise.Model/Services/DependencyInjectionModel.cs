using MetrologicalServiceEnterprise.Model.Data;
using MetrologicalServiceEnterprise.Model.Repositories;
using MetrologicalServiceEnterprise.Model.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MetrologicalServiceEnterprise.Model.Services;

public static class DependencyInjectionModel
{
    public static void AddInjectionModel(this IServiceCollection services)
    {
        services.AddTransient<IRepositoryEmployees, RepositoryEmployees>();
        services.AddDbContext<MetrologicalServiceEnterpriseContext>();
    }
}
