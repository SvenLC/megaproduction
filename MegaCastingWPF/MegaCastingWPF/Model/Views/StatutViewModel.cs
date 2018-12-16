using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views
{
    public class StatutViewModel : BaseViewModel<T_R_STATUT_JURIDIQUE_JUR>
    {
        public StatutViewModel()
        {
            Content = new Liste<T_R_STATUT_JURIDIQUE_JUR>();
        }
    }
}
