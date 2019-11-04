using Bpms.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.Repositories
{
    public class DailyAttendanceRepository
    {
        private List<DailyAttendance> dailyAttendances;

        public DailyAttendanceRepository()
        {
            var tanaka = new Employee("00001", "田中太郎");
            var satou  = new Employee("00002", "佐藤次郎");

            var date20191104 = new Date(2019, 11, 4);
            var date20191105 = new Date(2019, 11, 5);
            var date20191201 = new Date(2019, 12, 1);



            dailyAttendances = new List<DailyAttendance>
            {
                new DailyAttendance(tanaka, date20191104, new WorkingStartTime(date20191104, 9,  0), new WorkingEndTime(date20191104, 18, 0), Category.Attendance),
                new DailyAttendance(tanaka, date20191105, new WorkingStartTime(date20191105, 10, 0), new WorkingEndTime(date20191105, 19, 0), Category.Abcence),
                new DailyAttendance(tanaka, date20191201, new WorkingStartTime(date20191201, 9, 0), new WorkingEndTime(date20191201, 18, 0), Category.Attendance),

                new DailyAttendance(satou, date20191104, new WorkingStartTime(date20191104, 9,  0), new WorkingEndTime(date20191104, 18, 0), Category.Attendance),
                new DailyAttendance(satou, date20191105, new WorkingStartTime(date20191105, 10, 0), new WorkingEndTime(date20191105, 19, 0), Category.Attendance),
                new DailyAttendance(satou, date20191201, new WorkingStartTime(date20191201, 9, 0), new WorkingEndTime(date20191201, 18, 0), Category.Attendance),
            };
        }

        public DailyAttendanceCollection Find(EmployeeNo no, Month month)
        {
            var result = dailyAttendances.Where(d =>
                     d.Employee.No == no &&
                     month.BeginninDate <= d.Date &&
                     d.Date <= month.EndingDate);

            return new DailyAttendanceCollection(result);
        }
    }
}
