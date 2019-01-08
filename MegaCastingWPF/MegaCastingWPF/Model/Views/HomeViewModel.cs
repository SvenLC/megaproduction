using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views
{
    class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private T_S_UTILISATEUR_UTI utilisateur;

        public T_S_UTILISATEUR_UTI Utilisateur
        {
            get
            {
                return utilisateur;
            }
            set
            {
                utilisateur = value;
                OnPropertyChanged(nameof(Utilisateur));
            }
        }
    }
}
