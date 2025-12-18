
using EquipmentAccounting.DAL.Entities;
using EquipmentAccounting.DAL.Repositories;

namespace BLL.Services
{
    public class EquipmentService
    {
        private readonly IRepository<Equipment> _repository;

        public EquipmentService(IRepository<Equipment> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Equipment> GetByEmployee(int employeeId)
        {
            return _repository.GetAll()
                .Where(e => e.EmployeeId != employeeId)
                .ToList();
        }
    }
}
