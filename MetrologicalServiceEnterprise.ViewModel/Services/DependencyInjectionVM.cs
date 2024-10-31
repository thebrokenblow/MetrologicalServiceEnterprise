using Microsoft.Extensions.DependencyInjection;
using MetrologicalServiceEnterprise.Model.Services;
using MetrologicalServiceEnterprise.ViewModel.PagesViewModel;
using MetrologicalServiceEnterprise.ViewModel.WindowsViewModel;
using MetrologicalServiceEnterprise.ViewModel.Services.Interfaces;
using MetrologicalServiceEnterprise.ViewModel.Factories;
using MetrologicalServiceEnterprise.ViewModel.Factories.Interfaces;
using Microsoft.Extensions.Configuration;

namespace MetrologicalServiceEnterprise.ViewModel.Services;

public static class DependencyInjectionVM
{
    public static void AddInjectionVM(this IServiceCollection services, IConfigurationRoot configuration)
    {
        services.AddTransient<MainWindowVM>();
        services.AddTransient<ListEmployeesPageVM>();
        services.AddTransient<AddEmployeePageVM>();

        services.AddSingleton<INavigationService, NavigationService>();
        services.AddSingleton<IFactoryPageVM, FactoryPageVM>();

        services.AddInjectionModel(configuration);
    }
}