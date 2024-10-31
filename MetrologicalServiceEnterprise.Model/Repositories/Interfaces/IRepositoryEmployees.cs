using MetrologicalServiceEnterprise.Model.Domain;
using MetrologicalServiceEnterprise.Model.Entities;

namespace MetrologicalServiceEnterprise.Model.Repositories.Interfaces;

public interface IRepositoryEmployees
{
    Task<IEnumerable<Employee>> GetRangeAsync(int countSkip, int countTake);
    Task<int> AddAsync(EmployeeCreateDto employeeDto);
}