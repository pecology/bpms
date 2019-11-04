using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.Domains
{
    public class Month
    {
        public Date Value { get;}
        public Month(int year, int month)
        {
            Value = new Date(year, month, 1);
        }

        public Date BeginninDate
        {
            get
            {
                return Value;
            }
        }

        public Date EndingDate
        {
            get
            {
                var lastDay = DateTime.DaysInMonth(Value.Value.Year, Value.Value.Month);
                return new Date(Value.Value.Year, Value.Value.Month, lastDay);
            }
        }
    }
}
