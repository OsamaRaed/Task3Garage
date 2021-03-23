using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Data.Models
{
    public class MaintenanceReportDbEntity
    {
        public int MaintenanceReportId { get; set; }
        public MaintenanceReportDbEntity MaintenanceReport { get; set; }
    }
}
