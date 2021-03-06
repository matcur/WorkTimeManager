using System;
using System.Collections.Generic;
using System.Text;
using WorkTimeManager.Core;

namespace WorkTimeManager.Models
{
    class Employee : Model
    {
        public long Id { get; set; }

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        public int Salary
        {
            get => salary;
            set
            {
                salary = value;
                OnPropertyChanged("Salary");
            }
        }

        public SalaryType SalaryType
        {
            get => salaryType;
            set
            {
                salaryType = value;
                OnPropertyChanged("SalaryType");
            }
        }

        public DateTime RecrutAt { get; set; }

        private string firstName;

        private string lastName;

        private int salary;

        private SalaryType salaryType;

        public Employee Copy()
        {
            return new Employee
            {
                FirstName = FirstName,
                LastName = LastName,
                Salary = Salary,
                SalaryType = SalaryType,
                RecrutAt = RecrutAt,
            };
        }
    }
}
