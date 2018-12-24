using MahApps.Metro.Controls;
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
    /// Logique d'interaction pour OffreEdit.xaml
    /// </summary>
    public partial class OffreEdit : MetroWindow
    {
        OffreEditModel Model;

        public OffreEdit(T_E_OFFRE_CASTING_CAST _Prospect = null)
        {
            InitializeComponent();

            Model = new OffreEditModel(_Prospect);

            this.DataContext = Model;

            this.CBX_Metier.ItemsSource = Database.MegeCastingDatabase.Current.T_R_METIER_MET.ToList();
            this.CBX_Prospect.ItemsSource = Database.MegeCastingDatabase.Current.T_H_CLIENT_CLI.ToList();
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.IsValid(this))
            {
                bool valid = true;

                if (CBX_Metier.SelectedItem == null)
                {
                    CBX_Metier.BorderBrush = Brushes.Red;
                    valid = false;
                }
                if (CBX_Prospect.SelectedItem == null)
                {
                    CBX_Prospect.BorderBrush = Brushes.Red;
                    valid = false;
                }
                DateTime temp;
                if (!DateTime.TryParse(Date1.Text, out temp))
                {
                    Date1.BorderBrush = Brushes.Red;
                    valid = false;
                }
                if (temp.Year < 1753 || temp.Year > 9999)
                {
                    Date1.BorderBrush = Brushes.Red;
                    valid = false;
                }
                if (!DateTime.TryParse(Date2.Text, out temp))
                {
                    Date2.BorderBrush = Brushes.Red;
                    valid = false;
                }
                if (temp.Year < 1753 || temp.Year > 9999)
                {
                    Date2.BorderBrush = Brushes.Red;
                    valid = false;
                }
                TimeSpan tempTime;
                if (!TimeSpan.TryParse(Duree.SelectedTime.ToString(), out tempTime))
                {
                    Duree.BorderBrush = Brushes.Red;
                    valid = false;
                }

                if (valid)
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
