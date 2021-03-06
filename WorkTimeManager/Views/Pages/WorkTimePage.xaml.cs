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
    /// Interaction logic for WorkTimePage.xaml
    /// </summary>
    public partial class WorkTimePage : Page
    {
        public List<Employee> Employees { get; }
        
        public WorkTimePage(List<Employee> employees)
        {
            InitializeComponent();
            Employees = employees;
        }
    }
}
