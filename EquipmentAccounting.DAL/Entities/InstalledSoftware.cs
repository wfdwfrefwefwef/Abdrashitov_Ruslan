using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentAccounting.DAL.Entities
{
    public class InstalledSoftware
    {
        public int InstalledId { get; set; }
        public int EquipmentId { get; set; }
        public int LicenseId { get; set; }
        public DateTime InstallDate { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual License License { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
    }

}
