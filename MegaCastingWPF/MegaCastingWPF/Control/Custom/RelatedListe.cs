﻿using MegaCastingWPF.Database;
using MegaCastingWPF.Interface;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace MegaCastingWPF.Control.Custom
{
    public class RelatedListe<T> : Content<T> where T : BaseExtend<T>, new()
    {
        private int Id;

        public RelatedListe(int id)
        {
            this.Id = id;
            this.Reload(this.StoreSource);
        }

        public override T GetSelectedElement()
        {
            throw new NotImplementedException();
        }

        public override void Reload(List<T> _StoreSource, string contain = "")
        {
            this.Children.Clear();

            CustomDataGrid dataGrid = new CustomDataGrid();

            dataGrid.Columns.Clear();

            dataGrid.AutoGenerateColumns = false;
            dataGrid.IsReadOnly = true;

            dataGrid.SelectionChanged += new SelectionChangedEventHandler(selectionChanged);

            if (StoreSource.Any())
            {
                foreach (DataGridColumn Column in StoreSource.First().previewList())
                {
                    dataGrid.Columns.Add(Column);
                }
            }


            dataGrid.ItemsSource = _StoreSource.Where(x => x.IsRelated(Id.ToString()));

            dataGrid.ContextMenu = this.getContextMenu();

            this.Children.Add(dataGrid);
        }

        public void selectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid DTG = sender as DataGrid;

            StoreObject = DTG.SelectedItem as T;
        }

    }
}
