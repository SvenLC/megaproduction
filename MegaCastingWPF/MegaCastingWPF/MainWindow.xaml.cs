using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCastingWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HamburgerMenuControl_OnItemClick(object sender, ItemClickEventArgs e)
        {

            GridContenu.Children.Clear();
            HamburgerMenuGlyphItem item = e.ClickedItem as HamburgerMenuGlyphItem;
            GridContenu.Children.Add(item.Tag as UIElement);

            //this.HamburgerMenuControl.Content = e.ClickedItem;
            //this.HamburgerMenuControl.IsPaneOpen = false;
        }


        private void LinkWebSite_Click(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo pInfo = new ProcessStartInfo("http://www.google.fr");

            try
            {
                p.StartInfo = pInfo;
                p.Start();

                p.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
