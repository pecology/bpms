using Bpms.Models.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.ViewModels
{
    public class DailyAttendanceViewModel
    {
        public string Day { get; private set;}
        public string DayOfWeek { get; private set;}
        public string StartTime { get; private set;}
        public string EndTime { get; private set;}
        public string ActualWorkHours { get; private set;}
        public string Category { get; private set;}

        private DailyAttendanceViewModel()
        {
        }

        public static DailyAttendanceViewModel FromEntity(DailyAttendance attendance)
        {
            var item = new DailyAttendanceViewModel();
            if(attendance.Category == Domains.Category.Attendance)
            {
                item.Day = attendance.Date.Day.ToString();
                item.DayOfWeek = attendance.Date.Value.ToString("ddd");
                item.StartTime = attendance.StartTime.value.ToString("HH:mm");
                item.EndTime = attendance.EndTime.value.ToString("HH:mm");
                item.ActualWorkHours = attendance.ActualWorkTimeSpan.ToString(@"hh\:mm");
            } else
            {
                item.Day = attendance.Date.Day.ToString();
                item.DayOfWeek = attendance.Date.Value.ToString("ddd");
                item.Category = attendance.Category.ToString();
            }
            return item;
        }

        public static DailyAttendanceViewModel Empty(Date date)
        {
            var emptyItem = new DailyAttendanceViewModel();
            emptyItem.Day = date.Day.ToString();
            emptyItem.DayOfWeek = date.Value.ToString("ddd");
            return emptyItem;
        }
    }
}
