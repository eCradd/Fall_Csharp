using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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

namespace MultiWindowWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Person CurrentPerson { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            CurrentPerson = new Person();
            
            //Keep 'this'
            DataContext= this;
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow(CurrentPerson)
            {
                Owner = this
            };
            editWindow.ShowDialog();
        }
    }
}
