using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeFirstApproachApplication.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }
        public string Gender { get; set; }

        public Company company { get; set; }
    }
}
