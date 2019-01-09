using MahApps.Metro.Controls;
using MegaCastingWPF.Control.UserControls.Views;
using MegaCastingWPF.Model.Extends;
using MegaCastingWPF.Model.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            GridContenu.Children.Add(new ConnectionView(this)); 
        }


        private void LinkWebSite_Click(object sender, RoutedEventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo pInfo = new ProcessStartInfo("https://megacastingwebsite.herokuapp.com/");

            try
            {
                p.StartInfo = pInfo;
                p.Start();

                p.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public bool connected(String UserName, String PassWord)
        {

            string result = T_S_UTILISATEUR_UTI.connect(UserName, PassWord);

            int id = 0;

            #region Old

                //if (Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.list().Where(x => x.UTI_LOGIN == UserName).Any())
                //{
                //    //T_S_UTILISATEUR_UTI utilisateur = Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.Where(x => x.UTI_LOGIN == UserName).First();

                //    if (comparePassWord(PassWord, utilisateur.UTI_MDP))
                //    {
                //        GridContenu.Children.Clear();
                //        GridContenu.Children.Add(new HomeView(utilisateur));

                //        return true;
                //    }
                //}

            #endregion

            if (result == "")
            {
                return false;
            }
            else {
                try
                {
                    Int32.TryParse(result, out id);
                }
                catch (Exception)
                {
                    id = 0;
                }
            }

            T_S_UTILISATEUR_UTI utilisateur = Database.MegeCastingDatabase.Current.T_S_UTILISATEUR_UTI.get(id);

            if (utilisateur != null)
            {
                GridContenu.Children.Clear();
                GridContenu.Children.Add(new HomeView(utilisateur));
            }
            else
            {
                MessageBox.Show("Un problème est survenue!", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            

            return true;

        }

        public Boolean comparePassWord(String PasswordFromBox, string PasswordUser)
        {
            /* Fetch the stored value */
            string savedPasswordHash = PasswordUser;
            /* Extract the bytes */
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
            /* Get the salt */
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            /* Compute the hash on the password the user entered */
            var pbkdf2 = new Rfc2898DeriveBytes(PasswordFromBox, salt, 10000);
            byte[] hash = pbkdf2.GetBytes(20);
            /* Compare the results */
            for (int i = 0; i < 20; i++)
                if (hashBytes[i + 16] != hash[i])
                    return false;

            return true;

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            GridContenu.Children.Clear();
            GridContenu.Children.Add(new ConnectionView(this));
        }
    }
}
