using MahApps.Metro.IconPacks;
using MegaCastingWPF.Interface;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MegaCastingWPF.Control.Custom
{
    public abstract class Content<T> : Grid, ICrud where T : BaseExtend, new()
    {
        public abstract void Reload(List<T> _StoreSource, string contain = "");

        private T storeObject;
        public T StoreObject
        {
            get
            {
                return storeObject;
            }
            set
            {
                storeObject = value;
            }
        }

        public List<T> StoreSource => new T().getSource().Cast<T>().ToList();

        public abstract T GetSelectedElement();

        public void Create()
        {
            StoreObject = new T();

            StoreObject.Create();

            this.Reload(this.StoreSource);
        }

        public void Update()
        {
            if (StoreObject != null)
            {
                storeObject.Update();

                this.Reload(this.StoreSource);
            }
        }

        public void Delete()
        {
            if (StoreObject != null)
            {
                StoreObject.Delete();
                this.Reload(this.StoreSource);
            }

        }

        public ContextMenu getContextMenu()
        {
            var IconEdit = new PackIconMaterial()
            {
                Kind = PackIconMaterialKind.Pen,
                Margin = new Thickness(4, 4, 2, 4),
                Width = 14,
                Height = 14,
                VerticalAlignment = VerticalAlignment.Center
            };
            var IconDelete = new PackIconMaterial()
            {
                Kind = PackIconMaterialKind.Delete,
                Margin = new Thickness(4, 4, 2, 4),
                Width = 14,
                Height = 14,
                VerticalAlignment = VerticalAlignment.Center
            };

            //Contexte menu
            ContextMenu contextMenu = new ContextMenu();

            MenuItem menuItem = new MenuItem()
            {
                Header = "Éditer"
            };

            menuItem.Click += new RoutedEventHandler(ContextMenu_Update);

            menuItem.Icon = IconEdit;

            contextMenu.Items.Add(menuItem);

            menuItem = new MenuItem()
            {
                Header = "Supprimer"
            };

            menuItem.Click += new RoutedEventHandler(ContextMenu_Delete);

            menuItem.Icon = IconDelete;

            contextMenu.Items.Add(menuItem);

            return contextMenu;
        }

        private void ContextMenu_Update(object sender, RoutedEventArgs e) => Update();

        private void ContextMenu_Delete(object sender, RoutedEventArgs e) => Delete();
    }
}
