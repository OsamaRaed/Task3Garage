using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Core.Dto
{
    public class CreateMaintenanceReportDto
    {
        public int MaintenanceReportId { get; set; }
        public FormFile FilePath { get; set; }
    }

}
