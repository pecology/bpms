using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.ViewModels
{
    public class DailyAttendanceListViewModel
    {
        public string SelectedYear { get; }
        public string SelectedMonth { get; }
        public IEnumerable<string> SelectableYears { get; }
        public IEnumerable<string> SelectableMonths { get; }
        public IEnumerable<DailyAttendanceViewModel> DailyAttendances { get; }
        
        public DailyAttendanceListViewModel(int selectedYear, int selectedMonth, IEnumerable<DailyAttendanceViewModel> dailyAttendances)
        {
            SelectedYear = selectedYear.ToString();
            SelectedMonth = selectedMonth.ToString();
            SelectableYears = BuildSelectableYears();
            SelectableMonths = BuildSelectableMonths();
            DailyAttendances = dailyAttendances;

        }

        private IEnumerable<string> BuildSelectableYears()
        {
            return Enumerable.Range(2000, DateTime.Now.Year).Select(y => y.ToString());
        }

        private IEnumerable<string> BuildSelectableMonths()
        {
            return Enumerable.Range(1, 12).Select(y => y.ToString());
        }
    }
}
