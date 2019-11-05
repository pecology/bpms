using Bpms.Models.Domains;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.ViewModels
{
    public class OneMonthDailyAttendancesViewModel : IEnumerable<DailyAttendanceViewModel>
    {
        private readonly IEnumerable<DailyAttendanceViewModel> innerEnumerable;

        public OneMonthDailyAttendancesViewModel(Month month, DailyAttendanceCollection dailyAttendances)
        {
            innerEnumerable = month.Dates.Select(date =>
            {
                var exists = dailyAttendances.list.Any(d => d.Date == date);
                if (exists)
                {
                    var dailyAttendance = dailyAttendances.list.First(d => d.Date == date);
                    return DailyAttendanceViewModel.FromEntity(dailyAttendance);
                }
                else
                {
                    return DailyAttendanceViewModel.Empty(date);
                }
            });
        }

        public IEnumerator<DailyAttendanceViewModel> GetEnumerator()
        {
            return innerEnumerable.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerEnumerable.GetEnumerator();
        }
    }
}
