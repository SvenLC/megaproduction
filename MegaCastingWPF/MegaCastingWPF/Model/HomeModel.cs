using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingWPF.Model
{
    public class HomeModel : INotifyPropertyChanged
    {
        private Visibility isClientOpen;
        private Visibility isPartenaireOpen;
        public List<Test> liste;

        public event PropertyChangedEventHandler PropertyChanged;

        public Visibility IsClientOpen
        {
            get
            {
                return isClientOpen;
            }
            set
            {
                isClientOpen = value;
                OnPropertyChanged(nameof(IsClientOpen));
            }
        }

        public Visibility IsPartenaireOpen
        {
            get
            {
                return isPartenaireOpen;
            }
            set
            {
                isPartenaireOpen = value;
                OnPropertyChanged(nameof(IsPartenaireOpen));
            }
        }


        public HomeModel()
        {
            isClientOpen = Visibility.Visible;
            isPartenaireOpen = Visibility.Visible;
            liste = new List<Test>();
            liste.Add(new Test("Bernard"));
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
