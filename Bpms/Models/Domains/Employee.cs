using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.Domains
{
    public class Employee
    {
        public EmployeeNo No { get; }
        public EmployeeName Name { get; }

        public Employee(string no, string name)
        {
            this.No = new EmployeeNo(no);
            this.Name = new EmployeeName(name);
        }
    }
}
