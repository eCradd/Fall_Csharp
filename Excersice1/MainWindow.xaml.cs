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

namespace Excersice1
{
    public class PersonClass 
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonClass() { }


    }


    public partial class MainWindow : Window
    {

        public PersonClass Person { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Assign the object 
            Person = (PersonClass)FindResource("Person1");//Ai assisnted for this step because person1 was throwing errors  

            // Refresh the label with the person's information
            UpdatePerson();
        }

        public void UpdatePerson()
        {
            if (Person != null)

            {

                personLabel.Content = $"Name: {Person.Name}, Age: {Person.Age}";
            }
        }
    }

}
