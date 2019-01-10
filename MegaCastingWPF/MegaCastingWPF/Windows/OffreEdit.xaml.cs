using MahApps.Metro.Controls;
using MegaCastingWPF.Model.Extends;
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

            List<T_R_METIER_MET> listeMetier = Database.MegeCastingDatabase.Current.T_R_METIER_MET.list();
            this.CBX_Metier.ItemsSource = listeMetier;
            List<T_E_PROSPECT_PRO> listeProspect = Database.MegeCastingDatabase.Current.T_E_PROSPECT_PRO.list();
            this.CBX_Prospect.ItemsSource = listeProspect;
            List<T_R_CONTRAT_CON> listeContrat = Database.MegeCastingDatabase.Current.T_R_CONTRAT_CON.list();
            this.CBX_Contrat.ItemsSource = listeContrat;
            List<T_R_LOCALISATION_LOC> listeLocalisation = Database.MegeCastingDatabase.Current.T_R_LOCALISATION_LOC.list();
            this.CBX_Localisation.ItemsSource = listeLocalisation;

            if (Model.StoreObject.MET_ID != 0)
            {
                CBX_Metier.SelectedItem = (listeMetier.Where(x => x.MET_ID == Model.StoreObject.MET_ID)).First();
            }
            if (Model.StoreObject.PRO_ID != 0)
            {
                CBX_Prospect.SelectedItem = (listeProspect.Where(x => x.PRO_ID == Model.StoreObject.PRO_ID)).First();
            }
            if (Model.StoreObject.CON_ID != 0)
            {
                CBX_Contrat.SelectedItem = (listeContrat.Where(x => x.CON_ID == Model.StoreObject.CON_ID)).First();
            }
            if (Model.StoreObject.LOC_ID != 0)
            {
                CBX_Localisation.SelectedItem = (listeLocalisation.Where(x => x.LOC_ID == Model.StoreObject.LOC_ID)).First();
            }
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.IsValid(this))
            {
                bool valid = true;

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
                if (CBX_Contrat.SelectedItem == null)
                {
                    CBX_Contrat.BorderBrush = Brushes.Red;
                    valid = false;
                }
                if (CBX_Localisation.SelectedItem == null)
                {
                    CBX_Localisation.BorderBrush = Brushes.Red;
                    valid = false;
                }
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
                if (CBX_Contact.SelectedItem == null)
                {
                    CBX_Contact.BorderBrush = Brushes.Red;

                    MessageBox.Show("Vous devez choisir un contact.","Erreur",MessageBoxButton.OK, MessageBoxImage.Error);
                    valid = false;
                }

                if (valid)
                {
                    Model.StoreObject.LOC_ID = ((T_R_LOCALISATION_LOC)CBX_Localisation.SelectedItem).LOC_ID;
                    Model.StoreObject.CON_ID = ((T_R_CONTRAT_CON)CBX_Contrat.SelectedItem).CON_ID;
                    Model.StoreObject.MET_ID = ((T_R_METIER_MET)CBX_Metier.SelectedItem).MET_ID;
                    Model.StoreObject.PRO_ID = ((T_E_PROSPECT_PRO)CBX_Prospect.SelectedItem).PRO_ID;
                    Model.StoreObject.CTC_ID = ((T_E_CONTACT_CTC)CBX_Contact.SelectedItem).CTC_ID;

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

        private void CBX_Localisation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox CBX = sender as ComboBox;
            if (CBX != null)
            {
                T_E_PROSPECT_PRO prospect = (CBX.SelectedItem as T_E_PROSPECT_PRO);

                if (prospect != null)
                {
                   List<T_E_CONTACT_CTC> listeContact = Database.MegeCastingDatabase.Current.T_E_CONTACT_CTC.list().Where(x => x.PRO_ID == prospect.PRO_ID).ToList();
                   this.CBX_Contact.ItemsSource = listeContact;

                    if (Model.StoreObject.CTC_ID != 0)
                    {
                        T_E_CONTACT_CTC Contacttest = listeContact.Where(x => x.CTC_ID == Model.StoreObject.CTC_ID).First();

                        if (Contacttest != null)
                        {
                            CBX_Contact.SelectedItem = Contacttest;
                        }
                    }
                }
            }

        }
    }
}
