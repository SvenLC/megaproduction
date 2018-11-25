using MegaCastingWPF.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MegaCastingWPF.Control.Custom
{
    public class CustomGroupBox : GroupBox
    {
        private T_E_PROSPECT_PRO prospect;

        public T_E_PROSPECT_PRO Prospect
        {
            get
            {
                return prospect;
            }
            set
            {
                prospect = value;
            }
        }

        public CustomGroupBox() : base()
        {
        }

        public static RoutedEvent ClickEvent =
        EventManager.RegisterRoutedEvent("Click", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomGroupBox));

        public event RoutedEventHandler Click
        {
            add { AddHandler(ClickEvent, value); }
            remove { RemoveHandler(ClickEvent, value); }
        }

        protected virtual void OnClick()
        {
            RoutedEventArgs args = new RoutedEventArgs(ClickEvent, this);
            RaiseEvent(args);
        }

        protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonUp(e);
            OnClick();
        }
    }
}
