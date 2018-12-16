using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views
{
    public class DomaineMetierViewModel : BaseViewModel<T_R_DOMAINE_METIER_DOM>
    {
        public DomaineMetierViewModel()
        {
            Content = new Liste<T_R_DOMAINE_METIER_DOM>();
        }
    }
}
