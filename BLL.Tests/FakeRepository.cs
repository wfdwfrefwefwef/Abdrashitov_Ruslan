using EquipmentAccounting.DAL.Entities;
using EquipmentAccounting.DAL.Repositories;

internal class FakeRepository<T> : IRepository<Department>
{
    public void Add(Department entity)
    {
        throw new NotImplementedException();
    }

    public IQueryable<Department> GetAll()
    {
        throw new NotImplementedException();
    }

    public Department? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Remove(Department entity)
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}