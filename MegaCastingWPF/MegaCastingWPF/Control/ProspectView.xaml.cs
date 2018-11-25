using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using MegaCastingWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

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

            loadListeEmptySearch();
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

            datagrid.AutoGenerateColumns = false;

            datagrid.SelectionChanged += new SelectionChangedEventHandler(DataGrid_SelectedChange);

            datagrid.Columns.Add(new DataGridTextColumn()
            {
                Header = "PRO_ID",
                Width = new DataGridLength(200),
                FontSize = 12,
                Binding = new Binding("PRO_ID")
            });

            datagrid.Columns.Add(new DataGridTextColumn()
            {
                Header = "PRO_NAME",
                Width = new DataGridLength(200),
                FontSize = 12,
                Binding = new Binding("PRO_NAME")
            });

            datagrid.ItemsSource = Model.liste.Where(x => x.PRO_NAME.Contains(contain));

            ListContent.Children.Clear();
            ListContent.Children.Add(datagrid);

        }

        private void loadVignette(UniformGrid grid, string contain = "")
        {
            grid.Children.Clear();
            grid.Columns = 5;

            foreach (T_E_PROSPECT_PRO item in Model.liste.Where(x => x.PRO_NAME.Contains(contain)))
            {
                CustomGroupBox cgb = new CustomGroupBox();

                cgb.Prospect = item;

                GroupBox gb = new GroupBox();

                cgb.Click += new RoutedEventHandler(CustomGroupBox_Click);

                cgb.Margin = new Thickness(2, 2, 2, 2);

                //Grille du header
                Grid gridHeader = new Grid();

                gridHeader.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Width = GridLength.Auto
                });
                gridHeader.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
                gridHeader.ColumnDefinitions.Add(new ColumnDefinition()
                {
                    Width = GridLength.Auto
                });

                TextBlock TBC = new TextBlock()
                {
                    Text = item.PRO_NAME,
                };

                TBC.SetValue(Grid.ColumnProperty, 0);

                CheckBox CBX = new CheckBox();

                CBX.IsEnabled = false;

                CBX.SetValue(Grid.ColumnProperty, 2);

                gridHeader.Children.Add(TBC);
                gridHeader.Children.Add(CBX);

                cgb.Header = gridHeader;

                //Grid contenu de la group box
                TextBlock tb = new TextBlock()
                {
                    Text = Convert.ToString(item.PRO_ID)
                };

                Grid g = new Grid();
                g.Children.Add(tb);

                cgb.Content = g;

                grid.Children.Add(cgb);
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

        private void DataGrid_SelectedChange(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dg = sender as DataGrid;

            T_E_PROSPECT_PRO prospect = dg.CurrentItem as T_E_PROSPECT_PRO;

            Model.Prospect = prospect;
        }

        private void CustomGroupBox_Click(object sender, RoutedEventArgs e)
        {
            CustomGroupBox CGB = sender as CustomGroupBox;

            Model.Prospect = CGB.Prospect;

            Grid CBGGrid = CGB.Header as Grid;

            foreach (UniformGrid item in ListContent.Children.OfType<UniformGrid>().ToList())
            {
                foreach (GroupBox item2 in item.Children.OfType<GroupBox>().ToList())
                {
                    Grid item3 = item2.Header as Grid;

                    foreach (CheckBox item5 in item3.Children.OfType<CheckBox>().ToList())
                    {
                        item5.IsChecked = false;
                    }
                }
            }

            foreach (CheckBox item5 in CBGGrid.Children.OfType<CheckBox>().ToList())
            {
                item5.IsChecked = true;
            }
        }
    }
}
