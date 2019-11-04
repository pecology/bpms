using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bpms.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bpms.Controllers
{
    public class DailyAttendancesController : Controller
    {
        public IActionResult Index()
        {
            var items = new List<DailyAttendanceViewModel>
            {
                new DailyAttendanceViewModel {Day = "1", DayOfWeek = "金", StartTime = "9:00", EndTime = "18:00", ActualWorkHours = "8:00", Category = ""},
                new DailyAttendanceViewModel {Day = "2", DayOfWeek = "土", StartTime = "9:00", EndTime = "18:00", ActualWorkHours = "8:00", Category = ""},
                new DailyAttendanceViewModel {Day = "3", DayOfWeek = "日", StartTime = "9:00", EndTime = "18:00", ActualWorkHours = "8:00", Category = ""}
            };
            return View(items);
        }
    }
}