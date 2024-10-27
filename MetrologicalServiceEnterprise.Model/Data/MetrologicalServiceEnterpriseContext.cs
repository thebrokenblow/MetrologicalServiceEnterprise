using Microsoft.EntityFrameworkCore;
using MetrologicalServiceEnterprise.Model.Entities;
using System.Reflection.Emit;
using MetrologicalServiceEnterprise.Model.EntityTypeConfigurations;

namespace MetrologicalServiceEnterprise.Model.Data;

public class MetrologicalServiceEnterpriseContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MetrologicalServiceEnterprise;Username=postgres;Password=1994");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}