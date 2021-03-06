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
using WorkTimeManager.Models;

namespace WorkTimeManager.Views.Pages
{
    /// <summary>
    /// Interaction logic for EmployeesPage.xaml
    /// </summary>
    public partial class EmployeesPage : Page
    {
        public List<Employee> Employees { get; }

        public EmployeesPage(List<Employee> employees)
        {
            DataContext = this;
            Employees = employees;
            InitializeComponent();
        }
    }
}
