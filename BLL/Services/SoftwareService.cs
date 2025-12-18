using EquipmentAccounting.DAL.Entities;
using EquipmentAccounting.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SoftwareService
    {
        private readonly IRepository<InstalledSoftware> _softwareRepo;
        private readonly IRepository<License> _licenseRepo;

        public SoftwareService(IRepository<InstalledSoftware> softwareRepo, IRepository<License> licenseRepo)
        {
            _softwareRepo = softwareRepo;
            _licenseRepo = licenseRepo;
        }

        public InstalledSoftware InstallSoftware(string name, int employeeId)
        {
            var software = new InstalledSoftware
            {
                Name = name,
                EmployeeId = employeeId,
                InstallDate = DateTime.Now
            };

            _softwareRepo.Add(software);
            _softwareRepo.Save();

            return software;
        }
    }
}
