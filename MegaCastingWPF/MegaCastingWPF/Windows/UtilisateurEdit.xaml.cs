using MahApps.Metro.Controls;
using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Model.Views.Edit;
using MegaCastingWPF.Rule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Logique d'interaction pour UtilisateurEdit.xaml
    /// </summary>
    public partial class UtilisateurEdit : MetroWindow
    {
        UtilisateurEditModel Model;

        public UtilisateurEdit(T_S_UTILISATEUR_UTI _Prospect = null)
        {
            InitializeComponent();

            Model = new UtilisateurEditModel(_Prospect);

            this.DataContext = Model;
        }

        private void ButtonValidate_Click(object sender, RoutedEventArgs e)
        {
            if (Validator.IsValid(this))
            {
                if ((PassWord.Password == "" || (PassWord.Password.Length < 6 || PassWord.Password.Length > 50)) && Model.StoreObject.UTI_ID == 0)
                {
                    PassWord.BorderBrush = Brushes.Red;
                }
                else
                {
                    Model.StoreObject.UTI_MDP = PassWord.Password;

                    this.DialogResult = true;
                    this.Close();
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
