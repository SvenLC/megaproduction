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
    public partial class ProspectView : BaseView
    {
        public ProspectViewModel Model;

        public ProspectView()
        {
            InitializeComponent();
            Model = new ProspectViewModel();
            this.DataContext = Model;

            ListContent.Children.Add(Model.Content as Liste<T_E_PROSPECT_PRO>);
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
            this.loadVignette(Model, ListContent);
        }

        private void ButtonListe_Click(object sender, RoutedEventArgs e)
        {
            this.loadListe(Model, ListContent);
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox TBX = sender as TextBox;
            Model.Content.Reload(TBX.Text);
        }

    }
}
