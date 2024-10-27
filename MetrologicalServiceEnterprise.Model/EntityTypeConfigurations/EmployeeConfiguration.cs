using MetrologicalServiceEnterprise.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetrologicalServiceEnterprise.Model.EntityTypeConfigurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder
            .ToTable("employees");

        builder
            .Property(x => x.Id)
            .HasColumnName("id");

        builder
            .HasKey(employee => employee.Id);

        builder
            .HasIndex(employee => employee.Id)
            .IsUnique();

        builder
            .Property(employee => employee.FirstName)
            .HasColumnName("first_name");

        builder
            .Property(employee => employee.LastName)
            .HasColumnName("last_name");

        builder
            .Property(employee => employee.Patronymic)
            .HasColumnName("patronymic");

        builder
           .Property(employee => employee.Email)
           .HasColumnName("email");

        builder
            .Property(employee => employee.ChiefId)
            .HasColumnName("chief_id");
    }
}