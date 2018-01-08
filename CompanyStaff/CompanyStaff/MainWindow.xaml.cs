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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;

namespace CompanyStaff
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AddEmployeeWindow AddEmployeeWindow;
        public int NewId = 0;        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow = new AddEmployeeWindow(this);
            AddEmployeeWindow.Show();
        }

        private void employeeListDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid gridEmployee = (DataGrid)sender;
            DataRowView selectedRow = gridEmployee.SelectedItem as DataRowView;

            if (selectedRow != null)
            {
                AddEmployeeWindow.nameTextBox.Text = selectedRow["Imię"].ToString();
                AddEmployeeWindow.lastNameTextBox.Text = selectedRow["Nazwisko"].ToString();
                AddEmployeeWindow.dateOfBirthDatePicker.Text = selectedRow["Data urodzenia"].ToString();
                AddEmployeeWindow.emailTextBox.Text = selectedRow["E-mail"].ToString();
                AddEmployeeWindow.phoneNumberTextBox.Text = selectedRow["Telefon"].ToString();
                AddEmployeeWindow.positionComboBox.Text = selectedRow["Stanowisko"].ToString();                
            }
        }

        private void editEmployeeDataButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployeeWindow = new AddEmployeeWindow(this);
            AddEmployeeWindow.Show();            
        }
    }
}
