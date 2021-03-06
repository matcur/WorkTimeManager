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
    /// Interaction logic for NewEmployeePage.xaml
    /// </summary>
    public partial class NewEmployeePage : Page
    {
        public NewEmployeePage()
        {
            InitializeComponent();

            DataContext = new NewEmployeeViewModel(new List<Employee>());
        }
    }
}
