using System;
using System.Collections.Generic;
using System.Text;
using WorkTimeManager.Core;
using WorkTimeManager.Models;

namespace WorkTimeManager.ViewModels
{
    public class WorkTimeViewModel : ViewModel
    {
        public List<Employee> Employees { get; }

        public Employee SelectedEmployee { get; set; }

        public WorkTime NewWorkTime { get; set; }

        public RelayCommand AddWorkTimeCommand => new RelayCommand(
            o =>
            {
                workTimes.Add(PrepareNewWorkTime(NewWorkTime));
                FlushWorkTimeCommand.Execute(new object());
            }
        );

        public RelayCommand FlushWorkTimeCommand => new RelayCommand(
            o =>
            {
                NewWorkTime.Amount = 0;
            }
        );

        private readonly List<WorkTime> workTimes;

        public WorkTimeViewModel(IEnumerable<Employee> employees, IEnumerable<WorkTime> workTimes)
        {
            Employees = new List<Employee>(employees);
            this.workTimes = new List<WorkTime>(workTimes);
        }

        private WorkTime PrepareNewWorkTime(WorkTime workTime)
        {
            var maxId = 1L;
            workTimes.ForEach(e =>
            {
                if (e.Id > maxId)
                    maxId = e.Id;
            });
            workTime.EmployeeId = SelectedEmployee.Id;
            workTime.ReportAt = DateTime.Now;

            return workTime;
        }
    }
}
