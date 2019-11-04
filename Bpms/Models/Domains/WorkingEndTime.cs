using System;

namespace Bpms.Models.Domains
{
    public class WorkingEndTime
    {
        public DateTime value;

        public WorkingEndTime(Date date, int hour, int minute)
        {
            value = new DateTime(date.Year, date.Month, date.Day, hour, minute, 0);
        }
    }
}