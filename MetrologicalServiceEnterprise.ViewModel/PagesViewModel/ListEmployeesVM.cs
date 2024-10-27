using MetrologicalServiceEnterprise.Model.Entities;
using MetrologicalServiceEnterprise.Model.Repositories.Interfaces;

namespace MetrologicalServiceEnterprise.ViewModel.PagesViewModel;

public class ListEmployeesVM(IRepositoryEmployees repositoryEmployees)
{
    public async Task<List<Employee>> GetEmployees()
    {
        return await repositoryEmployees.GetRange(0, 10);
    }
}