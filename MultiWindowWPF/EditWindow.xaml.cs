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

namespace MultiWindowWPF
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {

        private readonly Person _targetPerson;
        public EditWindow(Person person)
        {
            InitializeComponent();
            _targetPerson = person;

            TxtFirstName.Text = person.Fname;
            TxtLastName.Text = person.Lname; 

            TxtFirstName.Focus();
        }
        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(TxtAge.Text, out int parsedAge) || parsedAge < 0)
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtAge.Focus();
                return;
            }

            // Apply updates to main window model object
            _targetPerson.Fname = TxtFirstName.Text.Trim();
            _targetPerson.Lname = TxtLastName.Text.Trim();
            _targetPerson.Age = parsedAge;

            DialogResult = true;
            Close();
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
          
            DialogResult = false;
            Close();
        }

    }
}
