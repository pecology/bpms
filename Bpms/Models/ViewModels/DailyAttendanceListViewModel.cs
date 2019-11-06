using Bpms.Models.Domains;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public IEnumerable<SelectListItem> YearSelectListItems { get; }
        public IEnumerable<SelectListItem> MonthSelectListItems { get; }
        public IEnumerable<DailyAttendanceViewModel> DailyAttendances { get; }
        
        public DailyAttendanceListViewModel(int selectedYear, int selectedMonth, DailyAttendanceCollection dailyAttendances)
        {
            SelectedYear = selectedYear.ToString();
            SelectedMonth = selectedMonth.ToString();
            YearSelectListItems = BuildYearSelectListItems(selectedYear);
            MonthSelectListItems = BuildMonthSelectListItems(selectedMonth);
            DailyAttendances = new OneMonthDailyAttendancesViewModel(new Month(selectedYear, selectedMonth), dailyAttendances); ;
        }

        private IEnumerable<SelectListItem> BuildYearSelectListItems(int selectedYear)
        {
            return Enumerable.Range(2000, DateTime.Now.Year - 2000 + 1)
                             .Select(y => new SelectListItem { Text = y.ToString(), Value = y.ToString() });
        }

        private IEnumerable<SelectListItem> BuildMonthSelectListItems(int selectedMonth)
        {
            return Enumerable.Range(1, 12)
                             .Select(m => new SelectListItem { Text = m.ToString(), Value = m.ToString() });
        }
    }
}
