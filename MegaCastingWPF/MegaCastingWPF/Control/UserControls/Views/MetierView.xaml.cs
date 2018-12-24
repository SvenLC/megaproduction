using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
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
    public partial class MetierView : BaseView
    {
        public MetierViewModel Model;

        public MetierView()
        {
            InitializeComponent();
            Model = new MetierViewModel();
            this.DataContext = Model;

            ListContent.Children.Add(Model.Content as Liste<T_R_METIER_MET>);
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
            this.loadVignette<MetierViewModel, T_R_METIER_MET>(Model, ListContent, FilterTextBox);
        }

        private void ButtonListe_Click(object sender, RoutedEventArgs e)
        {
            this.loadListe<MetierViewModel, T_R_METIER_MET>(Model, ListContent, FilterTextBox);
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
