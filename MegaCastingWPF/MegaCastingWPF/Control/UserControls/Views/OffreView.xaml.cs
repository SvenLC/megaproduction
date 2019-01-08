using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Model.Views;
using MegaCastingWPF.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace MegaCastingWPF.Control.UserControls.Views
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class OffreView : BaseView
    {
        public OffreViewModel Model;

        public OffreView()
        {
            InitializeComponent();
            Model = new OffreViewModel();
            this.DataContext = Model;

            ListContent.Children.Add(Model.Content as Liste<T_E_OFFRE_CASTING_CAST_FORMA>);
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            Model.Content.Update();
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            Model.Content.Create();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            Model.Content.Delete();
        }

        private void ButtonVignette_Click(object sender, RoutedEventArgs e)
        {
            this.loadVignette<OffreViewModel, T_E_OFFRE_CASTING_CAST_FORMA>(Model, ListContent, FilterTextBox);
        }

        private void ButtonListe_Click(object sender, RoutedEventArgs e)
        {
            this.loadListe<OffreViewModel, T_E_OFFRE_CASTING_CAST_FORMA>(Model, ListContent, FilterTextBox);
        }

        private void TextBoxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox TBX = sender as TextBox;

            if (e.Key == Key.Enter)
            {
                Model.Content.Reload(Model.Content.StoreSource, TBX.Text);
            }
        }
    }
}
