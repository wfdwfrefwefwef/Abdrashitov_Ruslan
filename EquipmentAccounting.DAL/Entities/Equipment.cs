using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EquipmentAccounting.DAL.Entities
{
    public class Equipment
    {
        public int EquipmentId { get; set; }
        public string InventoryNumber { get; set; }
        public string Name { get; set; }
        public int EquipmentTypeId { get; set; }
        public int DepartmentId { get; set; }
        public int? EmployeeId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Status { get; set; }
    }
}
