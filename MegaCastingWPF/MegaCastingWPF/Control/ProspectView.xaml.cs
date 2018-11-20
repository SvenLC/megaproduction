using MegaCastingWPF.Model;
using System.Windows;
using System.Windows.Controls;

namespace MegaCastingWPF.Control
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class ProspectView : UserControl
    {
        public HomeModel home;

        public ProspectView()
        {
            InitializeComponent();
            home = new HomeModel();
            this.DataContext = home;
            this.DataGridContenu.ItemsSource = home.liste;
        }

        private void PartenaireShown(object sender, RoutedEventArgs e)
        {
            if (home.IsPartenaireOpen == Visibility.Visible)
                home.IsPartenaireOpen = Visibility.Collapsed;
            else
                home.IsPartenaireOpen = Visibility.Visible;
        }

        private void ClientShow(object sender, RoutedEventArgs e)
        {
            if (home.IsClientOpen == Visibility.Visible)
                home.IsClientOpen = Visibility.Collapsed;
            else
                home.IsClientOpen = Visibility.Visible;
        }
    }
}
