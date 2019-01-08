using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    class ContactEditModel : BaseEditModel<T_E_CONTACT_CTC>
    {
        public ContactEditModel(T_E_CONTACT_CTC _storeObject = null)
        {
            if (_storeObject == null)
                StoreObject = new T_E_CONTACT_CTC();
            else
                StoreObject = _storeObject;
        }
    }
}
