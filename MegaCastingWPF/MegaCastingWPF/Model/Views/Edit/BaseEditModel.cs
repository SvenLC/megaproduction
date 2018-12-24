using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views.Edit
{
    public class BaseEditModel<T> : INotifyPropertyChanged
    {
        private T storeObject;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }

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

    }

}