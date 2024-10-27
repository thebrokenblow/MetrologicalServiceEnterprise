namespace MetrologicalServiceEnterprise.Model.Entities;

public class Employee
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Patronymic { get; set; }
    public required string Email { get; set; }
    public required int ChiefId { get; set; }
}