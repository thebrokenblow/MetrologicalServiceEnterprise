using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MetrologicalServiceEnterprise.ViewModel.Core;
using MetrologicalServiceEnterprise.ViewModel.WindowsViewModel;
using MetrologicalServiceEnterprise.ViewModel.Services;

namespace MetrologicalServiceEnterprise.View;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    private readonly ServiceProvider serviceProvider;
    public App()
    {
        IServiceCollection services = new ServiceCollection();

        services.AddSingleton(provider => new MainWindow
        {
            DataContext = provider.GetService<MainWindowVM>()
        });

        services.AddInjectionVM();

        services.AddSingleton<Func<Type, BasePageVM>>(
            serviceProvider =>
            viewModelType =>
                (BasePageVM)serviceProvider.GetRequiredService(viewModelType));

        serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
        base.OnStartup(e);
    }
}