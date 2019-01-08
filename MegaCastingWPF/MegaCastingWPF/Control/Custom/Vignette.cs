using MegaCastingWPF.Database;
using MegaCastingWPF.Interface;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace MegaCastingWPF.Control.Custom
{
    public class Vignette<T> : Content<T> where T : BaseExtend<T>, new()
    {
        public override T GetSelectedElement()
        {
            throw new NotImplementedException();
        }

        public Vignette()
        {
            if (StoreSource == null)
                this.Reload(this.StoreSource);
            else
                this.Reload(this.StoreSource);
        }

        public override void Reload(List<T> _StoreSource, string contain = "")
        {
            this.Children.Clear();

            UniformGrid UFG = new UniformGrid();

            UFG.Columns = 5;

            UFG.Children.Clear();
            UFG.Columns = 5;


            foreach (T item in StoreSource.Where(x => x.IsRelated(contain)))
            {
                CustomGroupBox cgb = new CustomGroupBox() {
                    Prospect = item,
                    Margin = new Thickness(2, 2, 2, 2)
                };

                cgb.Click += new RoutedEventHandler(CustomGroupBox_Click);

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
                    Text = item.GetHeader()
                };

                CheckBox CBX = new CheckBox();

                CBX.IsEnabled = false;

                CBX.SetValue(Grid.ColumnProperty, 2);

                gridHeader.Children.Add(TBC);
                gridHeader.Children.Add(CBX);

                cgb.Header = gridHeader;


                StackPanel stackPanel = new StackPanel();
                stackPanel.Orientation = Orientation.Vertical;

                foreach (TextBlock TBCBoucle in item.PreviewGroupBox())
                {
                    stackPanel.Children.Add(TBCBoucle);
                }

                cgb.Content = stackPanel;

                cgb.ContextMenu = this.getContextMenu();

                UFG.Children.Add(cgb);
            }

            this.Children.Add(UFG);
        }

        private void CustomGroupBox_Click(object sender, RoutedEventArgs e)
        {
            CustomGroupBox CGB = sender as CustomGroupBox;

            StoreObject = CGB.Prospect as T;

            Grid CBGGrid = CGB.Header as Grid;

            foreach (UniformGrid item in this.Children.OfType<UniformGrid>().ToList())
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

            CBGGrid.Children.OfType<CheckBox>().First().IsChecked = true;

        }
    }
}
