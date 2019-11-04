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
    }
}
