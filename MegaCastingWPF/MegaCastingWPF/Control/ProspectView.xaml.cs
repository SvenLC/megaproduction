using MegaCastingWPF.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace MegaCastingWPF.Control
{
    /// <summary>
    /// Interaction logic for AboutView.xaml
    /// </summary>
    public partial class ProspectView : UserControl
    {
        public ProspectModel Model;

        public ProspectView()
        {
            InitializeComponent();
            Model = new ProspectModel();
            this.DataContext = Model;
            //this.DataGridContenu.ItemsSource = Model.liste;
        }

        private void Context_Delete(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Delete");
        }

        private void Context_Edit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit");
        }

        private void DataGridContenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid Data = sender as DataGrid;

            Test selectedPerson = Data.CurrentItem as Test;

            Model.Person = selectedPerson;
        }

        private void ButtonVignette_Click(object sender, RoutedEventArgs e)
        {
            loadVignetteEmptySearch();
        }

        private void ButtonListe_Click(object sender, RoutedEventArgs e)
        {
            loadListeEmptySearch();
        }

        private void loadListe(DataGrid datagrid,string contain = "")
        {
            datagrid.Columns.Clear();

            datagrid.Columns.Add(new DataGridTextColumn()
            {
                Header = "Nom",
                Width = new DataGridLength(200),
                FontSize = 12,
                Binding = new Binding("Nom")
            });

            datagrid.ItemsSource = Model.liste.Where(x => x.Nom.Contains(contain));

            ListContent.Children.Clear();
            ListContent.Children.Add(datagrid);

        }

        private void loadVignette(UniformGrid grid, string contain = "")
        {
            grid.Children.Clear();
            grid.Columns = 5;

            foreach (Test item in Model.liste.Where(x => x.Nom.Contains(contain)))
            {
                GroupBox gp = new GroupBox();

                gp.Margin = new Thickness(2, 2, 2, 2);

                TextBlock tb = new TextBlock()
                {
                    Text = item.Nom
                };

                Grid g = new Grid();
                g.Children.Add(tb);

                gp.Content = g;

                grid.Children.Add(gp);
            }

            ListContent.Children.Clear();
            ListContent.Children.Add(grid);
        }

        private void loadSearch(DataGrid datagrid, string contain) => loadListe(datagrid, contain);
        private void loadSearch(UniformGrid grid, string contain) => loadVignette(grid,contain);
        private void loadListeEmptySearch() => loadListe(new DataGrid());
        private void loadVignetteEmptySearch() => loadVignette(new UniformGrid());

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if(ListContent.Children.OfType<DataGrid>().Any()){
                loadListe(ListContent.Children.OfType<DataGrid>().First(), textBox.Text);
            }
            else
            {
                loadSearch(ListContent.Children.OfType<UniformGrid>().First(), textBox.Text);
            }
        }
    }
}
