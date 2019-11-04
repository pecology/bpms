using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bpms.Models.Domains;
using Bpms.Models.Repositories;

namespace Bpms.Models.Services
{
    public class DailyAttendanceService
    {
        private DailyAttendanceRepository repository;

        public DailyAttendanceService()
        {
            repository = new DailyAttendanceRepository();
        }

        public DailyAttendanceCollection Find(string employeeId, int year, int month)
        {
            return repository.Find(new EmployeeNo(employeeId), new Month(year, month));
        }
    }
}
