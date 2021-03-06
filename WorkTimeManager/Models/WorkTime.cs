using System;
using System.Collections.Generic;
using System.Text;
using WorkTimeManager.Core;

namespace WorkTimeManager.Models
{
    public class WorkTime : Model
    {
        public long Id { get; set; }

        public long EmployeeId { get; set; }

        public DateTime ReportAt { get; set; }

        public long Amount { get; set; }
    }
}
