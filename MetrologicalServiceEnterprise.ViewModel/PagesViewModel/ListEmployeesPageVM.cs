using CommunityToolkit.Mvvm.Input;
using MetrologicalServiceEnterprise.Model.Entities;
using MetrologicalServiceEnterprise.Model.Repositories.Interfaces;
using MetrologicalServiceEnterprise.ViewModel.Core;
using MetrologicalServiceEnterprise.ViewModel.Services.Interfaces;

namespace MetrologicalServiceEnterprise.ViewModel.PagesViewModel;

public partial class ListEmployeesPageVM : BasePageVM
{
    private readonly IRepositoryEmployees _repositoryEmployees;

    private List<Employee>? requestEmployees;
    public List<Employee>? RequestEmployees
    {
        get => requestEmployees;
        private set => SetProperty(ref requestEmployees, value);
    }

    public INavigationService NavigationService { get; }
    public RelayCommand NavigateToAddEmployeeCommand { get; }

    public ListEmployeesPageVM(IRepositoryEmployees repositoryEmployees, INavigationService navigationService)
    {
        _repositoryEmployees = repositoryEmployees;
        NavigationService = navigationService;

        NavigateToAddEmployeeCommand = new(navigationService.NavigateTo<AddEmployeePageVM>);

        RequestEmployeesRangeAsync().GetAwaiter();
    }

    [RelayCommand]
    private async Task RequestEmployeesRangeAsync()
    {
        var employees = await LoadEmployeesRangeAsync();
        RequestEmployees = new(employees);
    }

    private async Task<IEnumerable<Employee>> LoadEmployeesRangeAsync() =>
         await _repositoryEmployees.GetRangeAsync(0, 20);
}