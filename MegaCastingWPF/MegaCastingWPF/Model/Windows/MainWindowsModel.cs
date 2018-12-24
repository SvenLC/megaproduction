using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingWPF.Model.Windows
{
    class MainWindowsModel : INotifyPropertyChanged
    {
        public MainWindowsModel()
        {
            
        }

        private string test;

        public string Test
        {
            get
            {
                return test;
            }
            set
            {
                test = value;
                OnPropertyChanged(nameof(Test));
            }
        }

        private Visibility isVisible;

        public Visibility IsVisible
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible = value;
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
