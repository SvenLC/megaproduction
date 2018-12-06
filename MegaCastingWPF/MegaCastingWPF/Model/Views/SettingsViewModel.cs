using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingWPF.Model.Views
{
    public class SettingsViewModel : INotifyPropertyChanged
    {

        private Visibility isAccentOpen;
        private Visibility isCouleurOpen;


        public Visibility IsAccentOpen
        {
            get
            {
                return isAccentOpen;
            }
            set
            {
                isAccentOpen = value;
                OnPropertyChanged(nameof(IsAccentOpen));
            }
        }


        public Visibility IsCouleurOpen
        {
            get
            {
                return isCouleurOpen;
            }
            set
            {
                isCouleurOpen = value;
                OnPropertyChanged(nameof(IsCouleurOpen));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public SettingsViewModel()
        {
            IsCouleurOpen = Visibility.Visible;
            IsAccentOpen = Visibility.Visible;
        }

    }

}

