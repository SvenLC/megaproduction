using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views
{
    public class MetierViewModel : BaseViewModel<T_R_METIER_MET>
    {
        public MetierViewModel()
        {
            Content = new Liste<T_R_METIER_MET>();
        }
    }
}
