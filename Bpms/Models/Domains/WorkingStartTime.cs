using System;

namespace Bpms.Models.Domains
{
    public class WorkingStartTime
    {
        public DateTime value;

        public WorkingStartTime(Date date, int hour, int minute)
        {
            value = new DateTime(date.Year, date.Month, date.Day, hour, minute, 0);
        }
    }
}