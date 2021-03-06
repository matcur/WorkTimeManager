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
using WorkTimeManager.ViewModels;

namespace WorkTimeManager.Views.Pages
{
    /// <summary>
    /// Interaction logic for WorkTimePage.xaml
    /// </summary>
    public partial class WorkTimePage : Page
    {
        public WorkTimePage(IEnumerable<Employee> employees)
        {
            DataContext = new WorkTimeViewModel(employees, new List<WorkTime>());
            InitializeComponent();
        }
    }
}
