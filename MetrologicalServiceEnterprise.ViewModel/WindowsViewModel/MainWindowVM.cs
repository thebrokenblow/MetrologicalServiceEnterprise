using MetrologicalServiceEnterprise.ViewModel.PagesViewModel;
using MetrologicalServiceEnterprise.ViewModel.Services.Interfaces;

namespace MetrologicalServiceEnterprise.ViewModel.WindowsViewModel;

public class MainWindowVM
{
    public INavigationService NavigationService { get; }

    public MainWindowVM(INavigationService navigationService)
    {
        NavigationService = navigationService;
        NavigationService.NavigateTo<ListEmployeesPageVM>();
    }
}