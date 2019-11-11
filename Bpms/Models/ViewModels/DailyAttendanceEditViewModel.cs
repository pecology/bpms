using Bpms.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.ViewModels
{
    public class DailyAttendanceEditViewModel
    {
        public string Year { get; private set;}
        public string Month { get; private set; }
        public string Day { get; private set;}

        public DailyAttendanceEditViewModel(int year, int month, int day)
        {
            Year = year.ToString();
            Month = month.ToString();
            Day = day.ToString();
        }
    }
}
