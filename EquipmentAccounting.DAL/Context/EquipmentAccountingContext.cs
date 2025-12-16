using EquipmentAccounting.DAL.Entities;
using Microsoft.EntityFrameworkCore;

public class EquipmentAccountingContext : DbContext
{
    public EquipmentAccountingContext(DbContextOptions<EquipmentAccountingContext> options)
        : base(options) { }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Equipment> Equipment { get; set; }
    public DbSet<EquipmentType> EquipmentTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>().ToTable("Departments");
        modelBuilder.Entity<Employee>().ToTable("Employees");
        modelBuilder.Entity<Equipment>().ToTable("Equipment");
        modelBuilder.Entity<EquipmentType>().ToTable("EquipmentTypes");
    }
}
