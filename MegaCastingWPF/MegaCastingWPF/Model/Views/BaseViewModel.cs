using MegaCastingWPF.Control.Custom;
using MegaCastingWPF.Database;
using MegaCastingWPF.Model.Extends;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingWPF.Model.Views
{
    public class BaseViewModel<T> : INotifyPropertyChanged where T : BaseExtend, new()
    {
        protected Content<T> content;

        public event PropertyChangedEventHandler PropertyChanged;

        public Content<T> Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                OnPropertyChanged(nameof(Content));
            }
        }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
