using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MegaCastingWPF.Control.Custom;
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
    /// Logique d'interaction pour ProspectEdit.xaml
    /// </summary>
    public partial class ProspectEdit : MetroWindow
    {
        ProspectEditModel Model;

        public ProspectEdit(T_E_PROSPECT_PRO _Prospect = null)
        {
            InitializeComponent();

            Model = new ProspectEditModel(_Prospect);
            
            this.DataContext = Model;

            Model.Content = new RelatedListe<T_E_CONTACT_CTC>(Model.StoreObject.PRO_ID);

            GridContact.Children.Add(Model.Content);

            List<T_R_STATUT_JURIDIQUE_JUR> listestatut = Database.MegeCastingDatabase.Current.T_R_STATUT_JURIDIQUE_JUR.list();

            this.CBX_Statut.ItemsSource = listestatut;

            NumberRule1.IsObligated = isClientSwitch.IsChecked.Value;
            NumberRule2.IsObligated = isClientSwitch.IsChecked.Value;
            TextRule3.IsObligated = isClientSwitch.IsChecked.Value;
            TextRule4.IsObligated = isClientSwitch.IsChecked.Value;
            TextRule5.IsObligated = isClientSwitch.IsChecked.Value;
            TextRule1.IsObligated = isPartenaireSwitch.IsChecked.Value;
            TextRule2.IsObligated = isPartenaireSwitch.IsChecked.Value;

            if (_Prospect.PAR_LOGIN != "" && _Prospect.PAR_LOGIN != null)
            {
                Model.partenaire = Database.MegeCastingDatabase.Current.T_H_PARTENAIRES_PAR.get(_Prospect.PRO_ID);

                TBX_PAR_LOGIN.Text = Model.partenaire.PAR_LOGIN;
                TBX_PAR_MDP.Text = Model.partenaire.PAR_MDP;
            }

            if (_Prospect.CLI_RNA != 0 && _Prospect.CLI_RNA != null)
            {
                Model.Client = Database.MegeCastingDatabase.Current.T_H_CLIENT_CLI.get(_Prospect.PRO_ID);
                Model.addresse = Database.MegeCastingDatabase.Current.T_E_ADRESSE_ADR.get(Model.Client.ADR_ID);

                TBX_CLI_RNA.Text = Model.Client.CLI_RNA.ToString();
                TBX_CLI_SIRET.Text = Model.Client.CLI_SIRET.ToString();
                CBX_Statut.SelectedItem = listestatut.Where(x => x.JUR_ID == Model.Client.JUR_ID);

                TBX_ADR_LIBELLE_RUE.Text = Model.addresse.ADR_LIBELLE_RUE;
                TBX_ADR_NUM_VOIE.Text = Model.addresse.ADR_NUM_VOIE;
                TBX_ADR_VILLE.Text = Model.addresse.ADR_NUM_VOIE;
            }
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.IsValid(this))
            {
                if (CBX_Statut.SelectedItem == null && Model.IsClient)
                {
                    CBX_Statut.BorderBrush = Brushes.Red;
                }
                else
                {
                    if (Model.IsClient)
                    {
                        int medInt = 0;
                        Int32.TryParse(this.TBX_CLI_RNA.Text, out medInt);
                        Model.Client.CLI_RNA = (int?)medInt;

                        int medInt2 = 0;
                        Int32.TryParse(this.TBX_CLI_SIRET.Text, out medInt2);
                        Model.Client.CLI_SIRET = (int?)medInt2;

                        Model.Client.JUR_ID = ((T_R_STATUT_JURIDIQUE_JUR)CBX_Statut.SelectedItem).JUR_ID;

                        Model.addresse.ADR_NUM_VOIE = this.TBX_ADR_NUM_VOIE.Text;
                        Model.addresse.ADR_LIBELLE_RUE = this.TBX_ADR_LIBELLE_RUE.Text;
                        Model.addresse.ADR_VILLE = this.TBX_ADR_VILLE.Text;
                    }
                    if (Model.IsPartenaire)
                    {
                        Model.partenaire.PAR_LOGIN = this.TBX_PAR_LOGIN.Text;
                        Model.partenaire.PAR_MDP = this.TBX_PAR_MDP.Text;
                    }

                    Model.StoreObject.partenaire = this.Model.partenaire;
                    Model.StoreObject.clientAdd = this.Model.Client;
                    Model.StoreObject.addresse = this.Model.addresse;

                    if (Model.partenaireDel != null)
                    {
                        Model.partenaireDel.Delete();
                    }

                    if (Model.ClientDel != null)
                    {
                        Model.ClientDel.Delete();
                    }

                    if (Model.addresseDel != null)
                    {
                        Model.addresseDel.Delete();
                    }

                    if (Model.listContact.Count > 0)
                    {
                        Model.StoreObject.listContactAdd = Model.listContact;
                    }

                    foreach (T_E_CONTACT_CTC item in Model.listContactDelete)
                    {
                        item.Delete();
                    }

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

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            Model.Content.Update();

            Model.Content.Reload(Model.listContact);
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            T_E_CONTACT_CTC contact = new T_E_CONTACT_CTC();
            contact.PRO_ID = Model.StoreObject.PRO_ID;

            bool succes = contact.Create();

            if (succes)
            {
                Model.listContact.Add(contact);
            }

            Model.Content.Reload(Model.listContact);
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (Model.Content.StoreObject.CTC_ID != 0)
            {
                Model.listContactDelete.Add(Model.Content.StoreObject);
            }

            Model.listContact.Remove(Model.Content.StoreObject);

            Model.Content.Reload(Model.listContact);
        }

        private void isClientSwitch_IsCheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitch CBX = sender as ToggleSwitch;

            NumberRule1.IsObligated = CBX.IsChecked.Value;
            NumberRule2.IsObligated = CBX.IsChecked.Value;

            TextRule3.IsObligated = CBX.IsChecked.Value;
            TextRule4.IsObligated = CBX.IsChecked.Value;
            TextRule5.IsObligated = CBX.IsChecked.Value;

        }

        private void isPartenaireSwitch_IsCheckedChanged(object sender, EventArgs e)
        {
            ToggleSwitch CBX = sender as ToggleSwitch;

            TextRule1.IsObligated = CBX.IsChecked.Value;
            TextRule2.IsObligated = CBX.IsChecked.Value;
        }
    }
}
