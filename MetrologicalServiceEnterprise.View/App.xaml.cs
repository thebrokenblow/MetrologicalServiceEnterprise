using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MetrologicalServiceEnterprise.ViewModel.WindowsViewModel;
using MetrologicalServiceEnterprise.ViewModel.Services;
using Microsoft.Extensions.Configuration;

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

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        var dbConnectionString = configuration.GetConnectionString("DbConnectionString");

        services.AddInjectionVM(configuration);
        serviceProvider = services.BuildServiceProvider();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = serviceProvider.GetRequiredService<MainWindow>();
        mainWindow.Show();
        base.OnStartup(e);
    }
}