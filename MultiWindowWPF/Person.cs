using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MultiWindowWPF
{
    public class Person : INotifyPropertyChanged //This will allow us to bind data
    {
        public string _fName = "jane";
        public string _lName = "doe";

        public int _age = 30;

        public String Fname
        {
            get => _fName; //first name
            set
            {
                if (_fName != value)
                {
                    _fName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }
        public String Lname //last name
        {
            get => _lName;
            set
            {
                if (_lName != value)
                {
                    _lName = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }

        public int Age //age 
        {
            get => _age;
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(IsAdult));
                }
            }
        }

            public string FullName => $"{Fname} {Lname}"; //age checking for adult or not
        public bool IsAdult => Age >= 18;

        public event PropertyChangedEventHandler PropertyChanged;

        
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
        
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    }
