﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Core.Dto
{
    public class UpdateMaintenanceServiceDto
    {
        public int CarId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExitDate { get; set; }
        public int MaintenanceReportId { get; set; }
    }
}
