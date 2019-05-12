using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using VierGewinnt.Core;

namespace VierGewinnt.View.WPF
{
    public class Farbconverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var farbe = value as Farbe;
            if (farbe == null) throw new ArgumentException("value ist keine Farbe");

            return new SolidColorBrush(Color.FromRgb(farbe.Rot, farbe.Gruen, farbe.Blau));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}