using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingWPF.Model.Views.Edit
{
    public class ProspectEditModel : INotifyPropertyChanged
    {
        private T_E_PROSPECT_PRO prospect;

        public ProspectEditModel(T_E_PROSPECT_PRO _prospect = null)
        {
            if (_prospect == null)
                prospect = new T_E_PROSPECT_PRO();
            else
                prospect = _prospect;
        }

        public Boolean IsClient
        {
            get
            {
                return prospect.T_H_CLIENT_CLI != null;
            }
            set
            {
                if (!IsClient)
                {
                    prospect.T_H_CLIENT_CLI = new T_H_CLIENT_CLI();
                    prospect.T_H_CLIENT_CLI.PRO_ID = prospect.PRO_ID;

                    OnPropertyChanged(nameof(Prospect));
                    OnPropertyChanged(nameof(IsClient));
                }
                else
                {
                    prospect.T_H_CLIENT_CLI = null;

                    OnPropertyChanged(nameof(Prospect));
                    OnPropertyChanged(nameof(IsClient));
                }
            }
        }

        public Boolean IsPartenaire
        {
            get
            {
                return prospect.T_H_PARTENAIRES_PAR != null;
            }
            set
            {
                if (!IsPartenaire)
                {
                    prospect.T_H_PARTENAIRES_PAR = new T_H_PARTENAIRES_PAR();
                    prospect.T_H_PARTENAIRES_PAR.PRO_ID = prospect.PRO_ID;

                    OnPropertyChanged(nameof(Prospect));
                    OnPropertyChanged(nameof(IsPartenaire));
                }
                else
                {
                    prospect.T_H_PARTENAIRES_PAR = null;

                    OnPropertyChanged(nameof(Prospect));
                    OnPropertyChanged(nameof(IsPartenaire));
                }
            }
        }

        public T_E_PROSPECT_PRO Prospect
        {
            get
            {
                return prospect;
            }
            set
            {
                prospect = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
