using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingWPF.Model.Views.Edit
{
    public class ProspectEditModel : BaseEditModel<T_E_PROSPECT_PRO>
    {
        public ProspectEditModel(T_E_PROSPECT_PRO _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_E_PROSPECT_PRO();
            else
                StoreObject = _storeObject;
        }

        public Boolean IsClient
        {
            get
            {
                //return StoreObject.T_H_CLIENT_CLI != null;

                throw new NotImplementedException();
            }
            set
            {
                //if (!IsClient)
                //{
                //    StoreObject.T_H_CLIENT_CLI = new T_H_CLIENT_CLI();
                //    StoreObject.T_H_CLIENT_CLI.T_E_ADRESSE_ADR = new T_E_ADRESSE_ADR();
                //    StoreObject.T_H_CLIENT_CLI.PRO_ID = StoreObject.PRO_ID;

                //    OnPropertyChanged(nameof(StoreObject));
                //    OnPropertyChanged(nameof(IsClient));
                //}
                //else
                //{
                //    StoreObject.T_H_CLIENT_CLI.T_E_ADRESSE_ADR = null;
                //    StoreObject.T_H_CLIENT_CLI = null;

                //    OnPropertyChanged(nameof(StoreObject));
                //    OnPropertyChanged(nameof(IsClient));
                //}

                throw new NotImplementedException();
            }
        }

        public Boolean IsPartenaire
        {
            get
            {
                //return StoreObject.T_H_PARTENAIRES_PAR != null;
                throw new NotImplementedException();

            }
            set
            {
                //if (!IsPartenaire)
                //{
                //    StoreObject.T_H_PARTENAIRES_PAR = new T_H_PARTENAIRES_PAR();
                //    StoreObject.T_H_PARTENAIRES_PAR.PRO_ID = StoreObject.PRO_ID;

                //    OnPropertyChanged(nameof(StoreObject));
                //    OnPropertyChanged(nameof(IsPartenaire));
                //}
                //else
                //{
                //    StoreObject.T_H_PARTENAIRES_PAR = null;

                //    OnPropertyChanged(nameof(StoreObject));
                //    OnPropertyChanged(nameof(IsPartenaire));
                //}
                throw new NotImplementedException();

            }
        }

        protected RelatedListe<T_E_CONTACT_CTC> content;

        public RelatedListe<T_E_CONTACT_CTC> Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                OnPropertyChanged(nameof(Content));
            }
        }
    }
}
