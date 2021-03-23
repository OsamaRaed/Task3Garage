﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Core.Dto
{
    public class UpdateCarDto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int CustomerId { get; set; }
        public List<int> MaintenanceService { get; set; }
    }
}
