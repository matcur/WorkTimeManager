using System;
using System.Collections.Generic;
using System.Text;
using WorkTimeManager.Core;

namespace WorkTimeManager.Models
{
    class WorkTime
    {
        public long Id { get; set; }

        public long EmployeeId { get; set; }

        public DateTime ReportAt { get; set; }

        public TimeSpan Amount { get; set; }
    }
}
