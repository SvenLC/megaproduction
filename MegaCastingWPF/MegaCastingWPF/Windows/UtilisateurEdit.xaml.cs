using MahApps.Metro.Controls;
using MegaCastingWPF.Database;
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
                if (PassWord.Password != "")
                {
                    byte[] salt;
                    new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                    var pbkdf2 = new Rfc2898DeriveBytes(PassWord.Password, salt, 10000);
                    byte[] hash = pbkdf2.GetBytes(20);

                    byte[] hashBytes = new byte[36];
                    Array.Copy(salt, 0, hashBytes, 0, 16);
                    Array.Copy(hash, 0, hashBytes, 16, 20);

                    string savedPasswordHash = Convert.ToBase64String(hashBytes);

                    Model.StoreObject.UTI_MDP = savedPasswordHash;

                }
                else
                {
                    if (Model.StoreObject.UTI_MDP == "" || Model.StoreObject.UTI_MDP == null)
                    {
                        byte[] salt;
                        new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                        var pbkdf2 = new Rfc2898DeriveBytes("", salt, 10000);
                        byte[] hash = pbkdf2.GetBytes(20);

                        byte[] hashBytes = new byte[36];
                        Array.Copy(salt, 0, hashBytes, 0, 16);
                        Array.Copy(hash, 0, hashBytes, 16, 20);

                        string savedPasswordHash = Convert.ToBase64String(hashBytes);

                        Model.StoreObject.UTI_MDP = savedPasswordHash;
                    }
                }

                this.DialogResult = true;
                this.Close();

            }
            
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
