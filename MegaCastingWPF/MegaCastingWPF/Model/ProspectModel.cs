using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingWPF.Model
{
    public class ProspectModel : INotifyPropertyChanged
    {
        private Boolean isClient;
        private Boolean isPartenaire;
        private Visibility isClientOpen;
        private Visibility isPartenaireOpen;
        public List<T_E_PROSPECT_PRO> liste;
        private T_E_PROSPECT_PRO prospect;

        public T_E_PROSPECT_PRO Prospect
        {
            get
            {
                return prospect;
            }
            set
            {
                prospect = value;
                OnPropertyChanged(nameof(Prospect));
            }
        }

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

        public Boolean IsClient
        {
            get
            {
                return isClient;
            }
            set
            {
                isClient = value;

                if (value == true)
                    IsClientOpen = Visibility.Visible;
                else
                    IsClientOpen = Visibility.Collapsed;

                OnPropertyChanged(nameof(IsClient));
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

        public Boolean IsPartenaire
        {
            get
            {
                return isPartenaire;
            }
            set
            {
                isPartenaire = value;


                if (value == true)
                    IsPartenaireOpen = Visibility.Visible;
                else
                    IsPartenaireOpen = Visibility.Collapsed;

                OnPropertyChanged(nameof(IsPartenaire));
            }
        }


        public ProspectModel()
        {
            IsClient = false;
            IsPartenaire = false;

            liste = MegeCastingDatabase.Current.T_E_PROSPECT_PRO.ToList();
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
