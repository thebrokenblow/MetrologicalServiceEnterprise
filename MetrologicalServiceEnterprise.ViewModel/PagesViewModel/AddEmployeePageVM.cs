using CommunityToolkit.Mvvm.Input;
using MetrologicalServiceEnterprise.Model.Domain;
using MetrologicalServiceEnterprise.Model.Repositories.Interfaces;
using MetrologicalServiceEnterprise.ViewModel.Core;
using MetrologicalServiceEnterprise.ViewModel.Services.Interfaces;

namespace MetrologicalServiceEnterprise.ViewModel.PagesViewModel;

public partial class AddEmployeePageVM(IRepositoryEmployees repository, INavigationService navigationService) : BasePageVM
{
    public EmployeeCreateDto EmployeeCreateDto { get; set; } = new()
    {
        FirstName = string.Empty,
        LastName = string.Empty,
        Email = string.Empty,
        Patronymic = string.Empty,
        ChiefId = null,
    };

    [RelayCommand]
    private async Task AddEmployeeAsync()
    {
        await repository.AddAsync(EmployeeCreateDto);
        navigationService.NavigateTo<ListEmployeesPageVM>();
    }
}