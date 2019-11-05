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
        public IActionResult List(int year, int month, string userNo)
        {
            var service = new DailyAttendanceService();
            var dailyAttendances = service.Find("00001", 2019, 11);
            var items = new OneMonthDailyAttendancesViewModel(new Month(2019, 11), dailyAttendances);
            var viewModel = new DailyAttendanceListViewModel(2019, 11, items);
            return View(viewModel);
        }
    }
}