using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace LabelBack
{
    public class ContentToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value?.ToString() == "Failed") return Brushes.LightCoral;
            return Brushes.LightGreen;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
