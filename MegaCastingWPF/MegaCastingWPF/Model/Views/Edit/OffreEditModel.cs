using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class OffreEditModel : BaseEditModel<T_E_OFFRE_CASTING_CAST_FORMA>
    {
        public OffreEditModel(T_E_OFFRE_CASTING_CAST_FORMA _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_E_OFFRE_CASTING_CAST_FORMA();
            else
                StoreObject = _storeObject;
        }
    }
}