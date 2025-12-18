

using BLL.Services;
using EquipmentAccounting.DAL.Entities;
using EquipmentAccounting.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;
using Xunit;

public class DepartmentServiceTests
{
    [Fact]
    public void GetAllDepartments_ShouldReturnExisting()
    {
        var repo = new FakeRepository<Department>();
        repo.Add(new Department { Name = "HR", Location = "Office 1" });
        repo.Add(new Department { Name = "IT", Location = "Office 2" });

        var service = new DepartmentService(repo);

        var departments = service.GetAll().ToList();

        Assert.Equal(2, departments.Count);
        Assert.Contains(departments, d => d.Name == "HR");
        Assert.Contains(departments, d => d.Name == "IT");
    }
}
