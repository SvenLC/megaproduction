using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class ContratEditModel : BaseEditModel<T_R_CONTRAT_CON>
    {
        public ContratEditModel(T_R_CONTRAT_CON _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_R_CONTRAT_CON();
            else
                StoreObject = _storeObject;
        }
    }
}