using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.Domains
{
    public class EmployeeNo
    {
        public string value { get; }
        public EmployeeNo(string no)
        {
            value = no;
        }

        public static bool operator ==(EmployeeNo one, EmployeeNo other)
        {
            return one.value == other.value;
        }

        public static bool operator !=(EmployeeNo one, EmployeeNo other)
        {
            return one.value == other.value;
        }
    }
}
