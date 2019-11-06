using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bpms.Models.Domains;
using Bpms.Models.Services;
using Bpms.Models.ViewForms;
using Bpms.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bpms.Controllers
{
    public class DailyAttendanceController : Controller
    {
        public IActionResult List(DailyAttendanceListViewForm form)
        {
            var year = (form.Year.HasValue) ? form.Year.Value : DateTime.Now.Year;
            var month = (form.Month.HasValue) ? form.Month.Value : DateTime.Now.Month;

            var service = new DailyAttendanceService();
            var dailyAttendances = service.Find("00001", year, month);

            var viewModel = new DailyAttendanceListViewModel(year, month, dailyAttendances);
            return View(viewModel);
        }

        public IActionResult Edit(DailyAttendanceEditViewForm form)
        {
            var year = form.Year;
            var month = form.Month;
            var day = form.Day;

            return View();
        }
    }
}