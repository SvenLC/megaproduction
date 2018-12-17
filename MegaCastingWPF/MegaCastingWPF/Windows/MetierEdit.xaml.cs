using MahApps.Metro.Controls;
using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using MegaCastingWPF.Model.Views.Edit;
using MegaCastingWPF.Rule;
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
using System.Windows.Shapes;

namespace MegaCastingWPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour ContactEdit.xaml
    /// </summary>
    public partial class MetierEdit : MetroWindow
    {
        MetierEditModel Model;

        public MetierEdit(T_R_METIER_MET _Prospect = null)
        {
            InitializeComponent();

            Model = new MetierEditModel(_Prospect);

            this.DataContext = Model;

            this.CBX_Statut.ItemsSource = Database.MegeCastingDatabase.Current.T_R_DOMAINE_METIER_DOM.ToList();
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.IsValid(this))
            {
                if (CBX_Statut.SelectedItem == null)
                {
                    CBX_Statut.BorderBrush = Brushes.Red;
                }
                else
                {
                    this.DialogResult = true;
                    Close();
                }
            }
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
