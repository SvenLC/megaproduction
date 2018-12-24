using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using MegaCastingWPF.Model.Views;
using System;
using System.Collections.Generic;
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
    /// Logique d'interaction pour ContratView.xaml
    /// </summary>
    public partial class ContratView : BaseView
    {
        public ContratViewModel Model;

        public ContratView()
        {
            InitializeComponent();
            Model = new ContratViewModel();
            this.DataContext = Model;

            ListContent.Children.Add(Model.Content as Liste<T_R_CONTRAT_CON>);
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
            this.loadVignette<ContratViewModel, T_R_CONTRAT_CON>(Model, ListContent, FilterTextBox);
        }

        private void ButtonListe_Click(object sender, RoutedEventArgs e)
        {
            this.loadListe<ContratViewModel, T_R_CONTRAT_CON>(Model, ListContent, FilterTextBox);
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
