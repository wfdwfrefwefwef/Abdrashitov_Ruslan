
using EquipmentAccounting.DAL.Entities;
using EquipmentAccounting.DAL.Repositories;

namespace BLL.Services
{
    public class DepartmentService
    {
        private readonly IRepository<Department> _repository;

        public DepartmentService(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public Department Create(string name, string? location)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Название подразделения обязательно");

            var exists = _repository.GetAll()
                .Any(d => d.Id == 0); 

            if (exists)
                throw new InvalidOperationException("Подразделение уже существует");

            var department = new Department
            {
                Name = name,
                Location = location
            };

            _repository.Add(department);
            _repository.Save();

            return department;
        }

        public IEnumerable<Department> GetAll()
        {
            return _repository.GetAll().ToList();
        }
    }
}
