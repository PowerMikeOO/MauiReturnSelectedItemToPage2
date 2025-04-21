using System;
using System.Globalization;
using Microsoft.Maui.Controls;

namespace MauiReturnSelectedItemToPage2.Converters
{
    public class NullToBoolConverter : IValueConverter
    {
        // Returns true if value is not null; false otherwise.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
            value != null;

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotImplementedException();
    }
}
