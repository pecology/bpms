using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.Domains
{
    public class Date
    {
        public DateTime Value { get; set; }

        public int Year { get { return Value.Year; } }
        public int Month { get { return Value.Month; } }
        public int Day { get { return Value.Day; } }

        public Date(int year, int month, int day)
        {
            Value = new DateTime(year, month, day);
        }

        public static bool operator <=(Date one, Date other)
        {
            return one.Value <= other.Value;
        }

        public static bool operator >=(Date one, Date other)
        {
            return one.Value >= other.Value;
        }

        public static bool operator ==(Date one, Date other)
        {
            return one.Value == other.Value;
        }

        public static bool operator !=(Date one, Date other)
        {
            return one.Value != other.Value;
        }

        public Date Next()
        {
            var nextDate = Value.AddDays(1);
            return new Date(nextDate.Year, nextDate.Month, nextDate.Day);
        }
    }
}
