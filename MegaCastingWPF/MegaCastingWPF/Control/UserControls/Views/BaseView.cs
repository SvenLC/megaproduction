using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using MegaCastingWPF.Model.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MegaCastingWPF.Control.UserControls.Views
{
    public abstract class BaseView : UserControl
    {
        public void loadVignette<T>(T Model,Grid ListContent) where T : BaseViewModel
        {
            Model.Content = new Vignette<T_E_PROSPECT_PRO>(MegeCastingDatabase.Current.T_E_PROSPECT_PRO.ToList());
            ListContent.Children.Clear();
            ListContent.Children.Add(Model.Content as Vignette<T_E_PROSPECT_PRO>);
        }

        public void loadListe<T>(T Model, Grid ListContent) where T : BaseViewModel
        {
            Model.Content = new Liste<T_E_PROSPECT_PRO>(MegeCastingDatabase.Current.T_E_PROSPECT_PRO.ToList());
            ListContent.Children.Clear();
            ListContent.Children.Add(Model.Content as Liste<T_E_PROSPECT_PRO>);
        }
    }
}
