using MegaCastingWPF.Model.Views;
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

namespace MegaCastingWPF.Control.UserControls.Views
{
    /// <summary>
    /// Logique d'interaction pour ConnectionView.xaml
    /// </summary>
    public partial class ConnectionView : UserControl
    {
        MainWindow windowsReference;
        ConnectionViewModel Model;

        public ConnectionView(MainWindow windowsReference)
        {
            InitializeComponent();

            this.windowsReference = windowsReference;

            Model = new ConnectionViewModel();
            this.DataContext = Model;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool response = windowsReference.connected(Model.UserName, PassWord.Password);

            if (!response)
            {
                Model.Error = "Le couple Identidiant/Mot de Passe n'existe pas";
            }
        }

        private void PassWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                bool response = windowsReference.connected(Model.UserName, PassWord.Password);

                if (!response)
                {
                    Model.Error = "Le couple Identidiant/Mot de Passe n'existe pas";
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UserName.Focus();
        }
    }
}
