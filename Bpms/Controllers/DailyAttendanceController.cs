using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var items = dailyAttendances.list.Select(d => new DailyAttendanceViewModel(d));
            return View(items);
        }
    }
}