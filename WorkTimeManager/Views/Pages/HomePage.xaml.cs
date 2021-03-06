using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkTimeManager.Core;
using WorkTimeManager.Models;

namespace WorkTimeManager.Views.Pages
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private readonly Func<object, bool> navigator;

        private readonly List<Employee> employees = new List<Employee> 
        {
            new Employee{ FirstName = "Jhon", LastName = "Wizard", SalaryType = SalaryType.Day },
            new Employee{ FirstName = "Liza", LastName = "Wizard", SalaryType = SalaryType.Day },
            new Employee{ FirstName = "Jhon - 2", LastName = "Wizard - 1", SalaryType = SalaryType.Day },
        };

        public HomePage(Func<object, bool> navigator)
        {
            InitializeComponent();
            this.navigator = navigator;
        }

        private void NavigateToEmployees(object sender, MouseButtonEventArgs e)
        {
            navigator.Invoke(new EmployeesPage(employees));
        }

        private void NavigateToWorkTime(object sender, MouseButtonEventArgs e)
        {
            navigator.Invoke(new WorkTimePage(employees));
        }

        private void NavigateToNewEmployee(object sender, MouseButtonEventArgs e)
        {
            navigator.Invoke(new NewEmployeePage(employees));
        }
    }
}
