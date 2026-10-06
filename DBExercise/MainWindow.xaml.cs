using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace DBExercise
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _boundText;





        public string BoundText
        {
            get => _boundText;
            set
            {
                if (_boundText != value)
                {
                    _boundText = value;
                    OnPropertyChanged(nameof(BoundText));
                }
            }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnShowText_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Current BoundText value: '{BoundText}'", "BoundText Value");
        }

        // Exercise 3 Button Click: Programmatically change BoundText value
        private void BtnSetText_Click(object sender, RoutedEventArgs e)
        {
            BoundText = "Hello from INotifyPropertyChanged!";
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
