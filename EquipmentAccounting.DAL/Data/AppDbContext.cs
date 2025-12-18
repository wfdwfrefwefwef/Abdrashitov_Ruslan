using EquipmentAccounting.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Equipment> Equipments { get; set; } = null!;
        public DbSet<EquipmentType> EquipmentTypes { get; set; } = null!;
        public DbSet<InstalledSoftware> InstalledSoftwares { get; set; } = null!;
        public DbSet<License> Licenses { get; set; } = null!;
        public DbSet<MovementHistory> MovementHistories { get; set; } = null!;



    }
}
