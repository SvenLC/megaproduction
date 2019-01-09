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
        public T_H_CLIENT_CLI Client = null;
        public T_E_ADRESSE_ADR addresse = null;
        public T_H_PARTENAIRES_PAR partenaire = null;

        public T_H_CLIENT_CLI ClientDel = null;
        public T_E_ADRESSE_ADR addresseDel = null;
        public T_H_PARTENAIRES_PAR partenaireDel = null;

        public List<T_E_CONTACT_CTC> listContact = new List<T_E_CONTACT_CTC>();
        public List<T_E_CONTACT_CTC> listContactDelete = new List<T_E_CONTACT_CTC>();

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
                return Client != null;
            }
            set
            {
                if (!IsClient)
                {
                    Client = new T_H_CLIENT_CLI();
                    addresse = new T_E_ADRESSE_ADR();

                    //OnPropertyChanged(nameof(StoreObject));
                    OnPropertyChanged(nameof(IsClient));
                }
                else
                {
                    if (addresse.ADR_ID != 0)
                    {
                        addresseDel = addresse;
                    }

                    if (Client.PRO_ID != 0)
                    {
                        ClientDel = Client;
                    }

                    addresse = null;
                    Client = null;

                    //OnPropertyChanged(nameof(StoreObject));
                    OnPropertyChanged(nameof(IsClient));
                }
            }
        }

        public Boolean IsPartenaire
        {
            get
            {
                return partenaire != null;

            }
            set
            {
                if (!IsPartenaire)
                {
                    partenaire = new T_H_PARTENAIRES_PAR();

                    //OnPropertyChanged(nameof(StoreObject));
                    OnPropertyChanged(nameof(IsPartenaire));
                }
                else
                {
                    if (partenaire.PRO_ID != 0)
                    {
                        partenaireDel = partenaire;
                    }

                    partenaire = null;

                    //OnPropertyChanged(nameof(StoreObject));
                    OnPropertyChanged(nameof(IsPartenaire));
                }

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
