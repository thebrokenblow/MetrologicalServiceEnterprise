using Dapper;
using MetrologicalServiceEnterprise.Model.Domain;
using MetrologicalServiceEnterprise.Model.Entities;
using MetrologicalServiceEnterprise.Model.Repositories.Interfaces;
using Npgsql;

namespace MetrologicalServiceEnterprise.Model.Repositories;

public class RepositoryEmployees(NpgsqlConnection connection) : IRepositoryEmployees
{
    public async Task<int> AddAsync(EmployeeCreateDto employeeCreateDto)
    {
        string commandText = $"select * from add_employee(@firstName, @lastName, @patronymic, @email, @chiefId)";

        var queryArguments = new
        {
            firstName = employeeCreateDto.FirstName,
            lastName = employeeCreateDto.LastName,
            patronymic = employeeCreateDto.Patronymic,
            email = employeeCreateDto.Email,
            chiefId = employeeCreateDto.ChiefId
        };

        var firstCell = await connection.ExecuteScalarAsync(commandText, queryArguments) ?? 
            throw new Exception();

        return (int)firstCell;
    }

    public async Task<IEnumerable<Employee>> GetRangeAsync(int countSkip, int countTake)
    {
        var queryArguments = new
        {
            CountSkip = countSkip,
            CountTake = countTake,
        };

        string commandText = @$"
                                select 
                                    id as {nameof(Employee.Id)}, 
                                    first_name as {nameof(Employee.FirstName)}, 
                                    last_name as {nameof(Employee.LastName)}, 
                                    patronymic as {nameof(Employee.Patronymic)}, 
                                    email as {nameof(Employee.Email)}, 
                                    chief_id as {nameof(Employee.ChiefId)}
                                from get_employees_range(@countSkip, @countTake);";

        var employees = await connection.QueryAsync<Employee>(commandText, queryArguments);

        return employees;
    }
}