using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipmentAccounting.DAL.Entities
{
    public class MovementHistory
    {
        public int MovementId { get; set; }
        public int EquipmentId { get; set; }
        public DateTime MovementDate { get; set; }
        public int? OldEmployeeId { get; set; }
        public int NewEmployeeId { get; set; }
        public string Note { get; set; }

        public virtual Equipment Equipment { get; set; }
        public virtual Employee OldEmployee { get; set; }
        public virtual Employee NewEmployee { get; set; }
    }
}
