using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using MegaCastingWPF.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingWPF.Model.Views
{
    public class ProspectViewModel : BaseViewModel
    {
        public ProspectViewModel()
        {
            Content = new Liste<T_E_PROSPECT_PRO>(MegeCastingDatabase.Current.T_E_PROSPECT_PRO.ToList());
        }
    }
}
