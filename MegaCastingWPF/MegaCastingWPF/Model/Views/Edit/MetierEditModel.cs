using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class MetierEditModel : BaseEditModel<T_R_METIER_MET>
    {
        public MetierEditModel(T_R_METIER_MET _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_R_METIER_MET();
            else
                StoreObject = _storeObject;
        }
    }
}