using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bpms.Controllers
{
    public class DailyAttendancesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}