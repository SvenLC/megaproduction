using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class DomaineMetierEditModel : BaseEditModel<T_R_DOMAINE_METIER_DOM>
    {
        public DomaineMetierEditModel(T_R_DOMAINE_METIER_DOM _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_R_DOMAINE_METIER_DOM();
            else
                StoreObject = _storeObject;
        }
    }
}