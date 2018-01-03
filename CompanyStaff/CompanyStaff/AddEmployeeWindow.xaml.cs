using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CompanyStaff
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public MainWindow mainWindow;

        public AddEmployeeWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = nameTextbox.Text;
            var lastname = lastNameTextbox.Text;

            var newEmployee = new Employee
            {
                Id = mainWindow.NewId++,
                Name = name,
                LastName = lastname
            };

            mainWindow.employeeListDataGrid.Items.Add(newEmployee);
            this.Close();
        }        
    }
}
