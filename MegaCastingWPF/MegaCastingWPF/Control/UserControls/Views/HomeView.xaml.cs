using MegaCastingWPF.Model;
using System.Windows.Controls;
using System.Windows;
using System.ComponentModel;
using MegaCastingWPF.Model.Windows;
using MahApps.Metro.Controls;
using System.Diagnostics;
using System;
using MegaCastingWPF.Database;
using MegaCastingWPF.Model.Views;

namespace MegaCastingWPF.Control.UserControls.Views
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {

        HomeViewModel Model;

        public HomeView(T_S_UTILISATEUR_UTI utilisateur)
        {
            InitializeComponent();
            Model = new HomeViewModel();

            this.DataContext = Model;

            HamburgerMenuItemCollection itemCollection = HamburgerMenuControl.ItemsSource as HamburgerMenuItemCollection;

            if (!utilisateur.UTI_ADMINISTRATEUR)
            {
                itemCollection.Remove(Utilisateurs);
                itemCollection.Remove(Domaines);
                itemCollection.Remove(Metiers);
                itemCollection.Remove(Contrats);
                itemCollection.Remove(Localisations);
                itemCollection.Remove(Status);
            }

            Model.Utilisateur = utilisateur;
        }

        private void HamburgerMenuControl_OnItemClick(object sender, ItemClickEventArgs e)
        {

            GridContenu.Children.Clear();
            HamburgerMenuIconItem item = e.ClickedItem as HamburgerMenuIconItem;
            GridContenu.Children.Add(item.Tag as UIElement);
        }


        private void HamburgerMenuControl_Loaded(object sender, RoutedEventArgs e)
        {
            GridContenu.Children.Add(new ProspectView());
        }
    }
}
