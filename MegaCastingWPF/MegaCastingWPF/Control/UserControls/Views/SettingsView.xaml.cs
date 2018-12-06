using MahApps.Metro;
using MegaCastingWPF.Model.Views;
using System.Windows;
using System.Windows.Controls;

namespace MegaCastingWPF.Control.UserControls.Views
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class SettingsView : BaseView
    {
        SettingsViewModel Model;

        public SettingsView()
        {
            InitializeComponent();
            Model = new SettingsViewModel();
            this.DataContext = Model;
        }

        private void ChangeWindowThemeButtonClick(object sender, RoutedEventArgs e)
        {
            var theme = ThemeManager.DetectAppStyle(Application.Current);
            ThemeManager.ChangeAppStyle(Application.Current, theme.Item2, ThemeManager.GetAppTheme("Base" + ((Button)sender).Content));
        }

        private void ChangeWindowAccentButtonClick(object sender, RoutedEventArgs e)
        {
            var theme = ThemeManager.DetectAppStyle(Application.Current);
            ThemeManager.ChangeAppStyle(Application.Current, ThemeManager.GetAccent(((Button)sender).Content.ToString()), theme.Item1);
        }

        private void ButtonExpendCouleur_Click(object sender, RoutedEventArgs e)
        {
            if (Model.IsCouleurOpen == Visibility.Visible)
                Model.IsCouleurOpen = Visibility.Collapsed;
            else
                Model.IsCouleurOpen = Visibility.Visible;
        }

        private void ButtonExpendAccent_Click(object sender, RoutedEventArgs e)
        {
            if (Model.IsAccentOpen == Visibility.Visible)
                Model.IsAccentOpen = Visibility.Collapsed;
            else
                Model.IsAccentOpen = Visibility.Visible;
        }
    }
}
