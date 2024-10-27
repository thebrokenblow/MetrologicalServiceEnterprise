using Microsoft.Extensions.DependencyInjection;
using MetrologicalServiceEnterprise.Model.Services;
using MetrologicalServiceEnterprise.ViewModel.PagesViewModel;
using MetrologicalServiceEnterprise.ViewModel.WindowsViewModel;
using MetrologicalServiceEnterprise.ViewModel.Services.Interfaces;
using MetrologicalServiceEnterprise.ViewModel.Factories;
using MetrologicalServiceEnterprise.ViewModel.Factories.Interfaces;

namespace MetrologicalServiceEnterprise.ViewModel.Services;

public static class DependencyInjectionVM
{
    public static void AddInjectionVM(this IServiceCollection services)
    {
        services.AddTransient<MainWindowVM>();
        services.AddTransient<ListEmployeesPageVM>();
        services.AddTransient<AddEmployeePageVM>();

        services.AddSingleton<INavigationService, NavigationService>();
        services.AddSingleton<IFactoryPageVM, FactoryPageVM>();

        services.AddInjectionModel();
    }
}