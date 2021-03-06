using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Data.Models
{
    public class EmployeeDbEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
        public DateTime EmploymentDate { get; set; }
        public List<MaintenanceServiceDbEntity> MaintenanceServices { get; set; }
    }
}
