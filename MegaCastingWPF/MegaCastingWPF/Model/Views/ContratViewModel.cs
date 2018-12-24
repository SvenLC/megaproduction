using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views
{
    public class ContratViewModel : BaseViewModel<T_R_CONTRAT_CON>
    {
        public ContratViewModel()
        {
            Content = new Liste<T_R_CONTRAT_CON>();
        }
    }
}
