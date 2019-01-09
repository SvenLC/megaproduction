using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using MegaCastingWPF.Model.Extends;
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
        public void loadVignette<T,E>(T Model,Grid ListContent, TextBox tbx) where T : BaseViewModel<E>, new() where E : BaseExtend<E>, new()
        {
            ListContent.Children.Clear();
            tbx.Text = "";

            Model.Content = new Vignette<E>();
            ListContent.Children.Add(Model.Content as Vignette<E>);
        }

        public void loadListe<T, E>(T Model, Grid ListContent, TextBox tbx) where T : BaseViewModel<E>, new() where E : BaseExtend<E>, new()
        {
            ListContent.Children.Clear();
            tbx.Text = "";


            Model.Content = new Liste<E>();
            ListContent.Children.Add(Model.Content as Liste<E>);
        }
    }
}
