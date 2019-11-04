using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.Domains
{
    public class DailyAttendanceCollection
    {
        public IEnumerable<DailyAttendance> list { get; }

        public DailyAttendanceCollection()
        {
            list = new List<DailyAttendance>();
        }

        public DailyAttendanceCollection(IEnumerable<DailyAttendance> dailyAttendances)
        {
            list = dailyAttendances;
        }

    }
}
