using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentAccounting.DAL.Entities
{
    public class License
    {
        public int LicenseId { get; set; }
        public string Name { get; set; }
        public string Vendor { get; set; }
        public string LicenseKey { get; set; }
        public DateTime? ExpirationDate { get; set; }

        public virtual ICollection<InstalledSoftware> InstalledSoftwares { get; set; }
    }
}
