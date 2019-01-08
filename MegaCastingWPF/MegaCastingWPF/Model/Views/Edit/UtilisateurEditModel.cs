using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class UtilisateurEditModel : BaseEditModel<T_S_UTILISATEUR_UTI>
    {
        public UtilisateurEditModel(T_S_UTILISATEUR_UTI _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_S_UTILISATEUR_UTI();
            else
                StoreObject = _storeObject;
        }
    }
}
