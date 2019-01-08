using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views
{
    public class UtilisateurViewModel : BaseViewModel<T_S_UTILISATEUR_UTI>
    {
        public UtilisateurViewModel()
        {
            Content = new Liste<T_S_UTILISATEUR_UTI>();
        }
    }
}
