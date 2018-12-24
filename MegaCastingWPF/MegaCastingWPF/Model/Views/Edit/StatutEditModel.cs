using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class StatutEditModel : BaseEditModel<T_R_STATUT_JURIDIQUE_JUR>
    {
        public StatutEditModel(T_R_STATUT_JURIDIQUE_JUR _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_R_STATUT_JURIDIQUE_JUR();
            else
                StoreObject = _storeObject;
        }
    }
}