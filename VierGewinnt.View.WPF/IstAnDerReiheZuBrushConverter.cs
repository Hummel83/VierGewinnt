using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace VierGewinnt.View.WPF
{
    public class IstAnDerReiheZuBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var istAnDerReihe = value != null && (bool) value;

            if (istAnDerReihe) return new SolidColorBrush(Colors.Silver);
            return new SolidColorBrush(Colors.Transparent);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}