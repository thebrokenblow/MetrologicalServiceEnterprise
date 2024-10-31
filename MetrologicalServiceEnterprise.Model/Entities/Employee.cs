using System.ComponentModel.DataAnnotations.Schema;

namespace MetrologicalServiceEnterprise.Model.Entities;

[Table("employees")]
public class Employee
{
    [Column("id")]
    public int Id { get; set; }

    [Column("first_name")]
    public required string FirstName { get; set; }

    [Column("last_name")]
    public required string LastName { get; set; }

    [Column("patronymic")]
    public required string Patronymic { get; set; }

    [Column("email")]
    public required string Email { get; set; }

    [Column("chief_id")]
    public required int? ChiefId { get; set; }
}