using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using MegaCastingWPF.Model.Views.Edit;
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

            this.CBX_Statut.ItemsSource = Database.MegeCastingDatabase.Current.T_R_STATUT_JURIDIQUE_JUR.ToList();
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void ButtonEdit_Click(object sender, RoutedEventArgs e)
        {
            Model.Content.Update();
        }

        private void ButtonCreate_Click(object sender, RoutedEventArgs e)
        {
            T_E_CONTACT_CTC contact = new T_E_CONTACT_CTC();
            contact.PRO_ID = Model.StoreObject.PRO_ID;

            bool succes = contact.Create();

            if (succes)
            {
                Model.StoreObject.T_E_CONTACT_CTC.Add(contact);
            }

            Model.Content.Reload(Model.StoreObject.T_E_CONTACT_CTC.ToList());
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            //Model.StoreObject.Delete();
        }
    }
}
