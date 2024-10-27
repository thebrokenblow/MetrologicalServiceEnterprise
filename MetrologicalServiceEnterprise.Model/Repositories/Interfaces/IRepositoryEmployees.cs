using MetrologicalServiceEnterprise.Model.Entities;

namespace MetrologicalServiceEnterprise.Model.Repositories.Interfaces;

public interface IRepositoryEmployees
{
    Task<List<Employee>> GetRange(int countSkip, int countTake);
}