using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace WPF_MultiConverterAndRules
{
    [ValueConversion(typeof(string),typeof(DateTime))]
    public class DateConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                return DateTime.Parse($"{values[0]}.{values[1]}.{values[2]}").ToShortDateString();
            }
            catch (Exception)
            {
                return DateTime.MinValue;
            }

        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            return ((string)value).Split('.');
        }
    }
}
