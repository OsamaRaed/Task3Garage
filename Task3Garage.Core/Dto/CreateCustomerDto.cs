using System;
using System.Collections.Generic;
using System.Text;

namespace Task3Garage.Core.Dto
{
    public class CreateCustomerDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public List<int> Cars { get; set; }
    }
}
