using System.Windows;
using MetrologicalServiceEnterprise.Model.Repositories;
using MetrologicalServiceEnterprise.ViewModel.PagesViewModel;

namespace MetrologicalServiceEnterprise.View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var listEmployees = new ListEmployeesVM(new RepositoryEmployees(new()));
        DataContext = listEmployees;
        var list = listEmployees.GetEmployees().GetAwaiter();
    }
}