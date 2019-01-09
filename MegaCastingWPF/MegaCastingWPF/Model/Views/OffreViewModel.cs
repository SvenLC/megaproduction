using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Model.Extends;
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
    public class OffreViewModel : BaseViewModel<T_E_OFFRE_CASTING_CAST_FORMA>
    {
        public OffreViewModel()
        {
            Content = new Liste<T_E_OFFRE_CASTING_CAST_FORMA>();
        }
    }
}
