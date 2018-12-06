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
        public abstract void Reload(string contain = "");

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

        private List<T> storeSource;
        public List<T> StoreSource
        {
            get
            {
                return storeSource;
            }
            set
            {
                storeSource = value;
            }
        }

        public abstract T GetSelectedElement();

        public void Create()
        {
            StoreObject = new T();

            //TODO : deselect all

            storeObject.Create();
        }

        public void Update()
        {
            storeObject.Update();
        }

        public void Delete()
        {
            storeObject.Delete();
        }

        public ContextMenu getContextMenu()
        {
            //Contexte menu
            ContextMenu contextMenu = new ContextMenu();

            MenuItem menuItem = new MenuItem()
            {
                Header = "Éditer"
            };

            menuItem.Click += new RoutedEventHandler(ContextMenu_Update);

            contextMenu.Items.Add(menuItem);

            menuItem = new MenuItem()
            {
                Header = "Supprimer"
            };

            menuItem.Click += new RoutedEventHandler(ContextMenu_Delete);

            contextMenu.Items.Add(menuItem);

            return contextMenu;
        }

        private void ContextMenu_Update(object sender, RoutedEventArgs e) => Update();

        private void ContextMenu_Delete(object sender, RoutedEventArgs e) => Delete();
    }
}
