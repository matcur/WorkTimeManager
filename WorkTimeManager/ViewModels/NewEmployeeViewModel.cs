using System;
using System.Collections.Generic;
using System.Text;
using WorkTimeManager.Core;
using WorkTimeManager.Models;

namespace WorkTimeManager.ViewModels
{
    public class NewEmployeeViewModel : ViewModel
    {
        public Employee NewEmployee { get; private set; }

        public RelayCommand AddEmployeeCommand => new RelayCommand(
            o =>
            {
                var newEmployee = NewEmployee.Copy();
                employees.Add(PrepareNewEmployee(newEmployee));
                FlushEmployeeCommand.Execute(new object());
            }
        );

        public RelayCommand FlushEmployeeCommand => new RelayCommand(
            o =>
            {
                NewEmployee.FirstName = "";
                NewEmployee.LastName = "";
                NewEmployee.Salary = 0;
                NewEmployee.SalaryType = SalaryType.Mounth;
            }
        );

        private readonly List<Employee> employees;

        public NewEmployeeViewModel(List<Employee> employees)
        {
            this.employees = employees;
            NewEmployee = new Employee();
        }

        private Employee PrepareNewEmployee(Employee employee)
        {
            var maxId = 1L;
            employees.ForEach(e =>
            {
                if (e.Id > maxId)
                    maxId = e.Id;
            });
            employee.Id = maxId;
            employee.RecrutAt = DateTime.Now;

            return employee;
        }
    }
}
