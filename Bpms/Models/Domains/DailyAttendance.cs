using System;

namespace Bpms.Models.Domains
{
    public class DailyAttendance
    {
        public Employee Employee { get; }
        public Date Date { get; }
        public WorkingStartTime StartTime { get; }
        public WorkingEndTime EndTime { get; }
        public TimeSpan ActualWorkTimeSpan { get {return EndTime.value - StartTime.value; } }
        public Category Category { get; }

        public DailyAttendance(Employee employee, Date date, WorkingStartTime startTime, WorkingEndTime endTime, Category category)
        {
            this.Employee = employee;
            this.Date = date;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Category = category;
        }
    }
}