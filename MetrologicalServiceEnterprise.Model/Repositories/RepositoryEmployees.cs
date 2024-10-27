using Microsoft.EntityFrameworkCore;
using MetrologicalServiceEnterprise.Model.Data;
using MetrologicalServiceEnterprise.Model.Entities;
using MetrologicalServiceEnterprise.Model.Repositories.Interfaces;

namespace MetrologicalServiceEnterprise.Model.Repositories;

public class RepositoryEmployees(MetrologicalServiceEnterpriseContext context) : IRepositoryEmployees
{
    public async Task<List<Employee>> GetRange(int countSkip, int countTake) =>
        await context.Employees
        .FromSql($"select * from get_employees_range({countSkip}, {countTake})")
        .ToListAsync();
}