using Bpms.Models.ViewForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bpms.Models.ViewForms
{
    public class DailyAttendanceEditPostViewForm
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public int? Day { get; set; }

        public IEnumerable<DailyAttendanceDetailViewForm> Details { get; set; }
    }
}
