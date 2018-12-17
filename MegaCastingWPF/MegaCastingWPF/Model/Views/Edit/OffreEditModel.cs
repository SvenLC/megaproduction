using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class OffreEditModel : BaseEditModel<T_E_OFFRE_CASTING_CAST>
    {
        public OffreEditModel(T_E_OFFRE_CASTING_CAST _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_E_OFFRE_CASTING_CAST();
            else
                StoreObject = _storeObject;
        }
    }
}