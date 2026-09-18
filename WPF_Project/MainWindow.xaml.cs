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

namespace WPF_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FirstNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LastNameBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
        private void HoursWorkedBox_TextChanged(object sender, TextChangedEventArgs e)
        {
              
        }

        private void SummarizeButton_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = FirstNameBox.Text;
            string LastName = LastNameBox.Text;
            double HourlyPayrate = 10.50;

            try //try catch block to catch any errors that may occur when converting the text to a double
            {
                double HoursWorked = Convert.ToDouble(HoursWorkedBox.Text);
                double GrossPay = HoursWorked * HourlyPayrate;
                // Display the summary 
                SummaryBox.Text = $"Employee: {FirstName} {LastName}\n" +
                                      $"Hours Worked: {HoursWorked}\n" +
                                      $"Hourly Rate: {HourlyPayrate:C}\n" +
                                      $"Total Pay: {GrossPay:C}";

            }
            catch (FormatException)//catchin them dag'on errors
            { 
                MessageBox.Show("Please enter valid numeric values for Hours Worked and Hourly Rate.", "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        { 
            FirstNameBox.Text = "";
            LastNameBox.Text = "";
            HoursWorkedBox.Text = "";
            SummaryBox.Text = "";
        }
    }
}