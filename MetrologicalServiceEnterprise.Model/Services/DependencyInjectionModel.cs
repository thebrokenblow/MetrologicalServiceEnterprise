using MetrologicalServiceEnterprise.Model.Repositories;
using MetrologicalServiceEnterprise.Model.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Npgsql;

namespace MetrologicalServiceEnterprise.Model.Services;

public static class DependencyInjectionModel
{
    public static void AddInjectionModel(this IServiceCollection services, IConfigurationRoot configuration)
    {
        services.AddTransient(x => 
            new NpgsqlConnection(configuration.GetConnectionString("DbConnectionString")));
        services.AddTransient<IRepositoryEmployees, RepositoryEmployees>();
    }
}
