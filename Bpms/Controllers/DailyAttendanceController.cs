using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bpms.Models.Domains;
using Bpms.Models.Services;
using Bpms.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bpms.Controllers
{
    public class DailyAttendanceController : Controller
    {
        public IActionResult List()
        {
            var service = new DailyAttendanceService();
            var dailyAttendances = service.Find("00001", 2019, 11);
            var items = CreateMonthlyDailyAttendances(new Month(2019, 11), dailyAttendances);
            return View(items);
        }

        private IEnumerable<DailyAttendanceViewModel> CreateMonthlyDailyAttendances(Month month, DailyAttendanceCollection dailyAttendances)
        {
            var monthlyDailyAttendances = month.Dates.Select(date =>
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
            return monthlyDailyAttendances;
        }
    }
}