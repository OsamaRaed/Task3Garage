﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Core.ViewModels
{
    public class CustomerVM
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<CarVM> cars { get; set; }
    }
}
