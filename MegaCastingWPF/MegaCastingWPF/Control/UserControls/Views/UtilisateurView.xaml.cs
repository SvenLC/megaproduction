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
    public partial class UtilisateurView : BaseView
    {
        public UtilisateurViewModel Model;

        public UtilisateurView()
        {
            InitializeComponent();
            Model = new UtilisateurViewModel();
            this.DataContext = Model;

            ListContent.Children.Add(Model.Content as Liste<T_S_UTILISATEUR_UTI>);
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            Model.Content.Update();

            Model.Content.Reload(Model.Content.StoreSource, FilterTextBox.Text);
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            Model.Content.Create();
            Model.Content.Reload(Model.Content.StoreSource, FilterTextBox.Text);
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            Model.Content.Delete();
            Model.Content.Reload(Model.Content.StoreSource, FilterTextBox.Text);
        }

        private void ButtonVignette_Click(object sender, RoutedEventArgs e)
        {
            this.loadVignette<UtilisateurViewModel, T_S_UTILISATEUR_UTI>(Model, ListContent, FilterTextBox);
        }

        private void ButtonListe_Click(object sender, RoutedEventArgs e)
        {
            this.loadListe<UtilisateurViewModel, T_S_UTILISATEUR_UTI>(Model, ListContent, FilterTextBox);
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
