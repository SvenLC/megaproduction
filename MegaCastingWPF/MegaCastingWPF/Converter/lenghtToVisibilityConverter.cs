using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MegaCastingWPF.Converter
{
    public class lenghtToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Int32 intValue = 0;

            if (value != null)
            {
                try
                {
                    intValue = ((String)value).Length;
                }
                catch (Exception)
                {
                    throw;
                }

                if (intValue > 0)
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Collapsed;
                }
            }
            else
            {
                return Visibility.Collapsed;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Boolean? booleanValue = value as Boolean?;

            if (booleanValue.HasValue)
            {
                if (booleanValue == true)
                {
                    return Visibility.Visible;
                }
                else
                {
                    return Visibility.Collapsed;
                }
            }
            else
            {
                return Visibility.Collapsed;
            }
        }
    }
}
