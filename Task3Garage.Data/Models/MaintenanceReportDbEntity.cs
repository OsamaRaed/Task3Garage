using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Data.Models
{
    public class MaintenanceReportDbEntity : BaseEntity
    {
        public int MaintenanceServiceDbEntityId { get; set; }
        public MaintenanceServiceDbEntity MaintenanceServiceDbEntity { get; set; }
        public string FilePath { get; set; }
        public FormFile FormFile { get; set; }
    }
}
