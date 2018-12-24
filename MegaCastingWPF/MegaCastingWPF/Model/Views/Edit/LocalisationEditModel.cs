using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class LocalisationEditModel : BaseEditModel<T_R_LOCALISATION_LOC>
    {
        public LocalisationEditModel(T_R_LOCALISATION_LOC _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_R_LOCALISATION_LOC();
            else
                StoreObject = _storeObject;
        }
    }
}