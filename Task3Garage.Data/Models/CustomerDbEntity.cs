﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Data.Models
{
    public class CustomerDbEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<CarDbEntity> cars{ get; set; }
    }
}
