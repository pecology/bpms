using Bpms.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.ViewModels
{
    public class DailyAttendanceViewModel
    {
        public string Day { get; set; }
        public string DayOfWeek { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ActualWorkHours { get; set; }
        public string Category { get; set; }

        public DailyAttendanceViewModel(DailyAttendance attendance)
        {
            if(attendance.Category == Domains.Category.Attendance)
            {
                Day = attendance.Date.Day.ToString();
                DayOfWeek = attendance.Date.Value.ToString("ddd");
                StartTime = attendance.StartTime.value.ToString("HH:mm");
                EndTime = attendance.EndTime.value.ToString("HH:mm");
                ActualWorkHours = attendance.ActualWorkTimeSpan.ToString(@"hh\:mm");
            } else
            {
                Day = attendance.Date.Day.ToString();
                DayOfWeek = attendance.Date.Value.ToString("ddd");
                Category = attendance.Category.ToString();
            }
            
        }
    }
}
