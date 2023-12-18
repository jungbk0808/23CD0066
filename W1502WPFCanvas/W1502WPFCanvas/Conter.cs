using System.Globalization;
using System.Windows.Data;

namespace W1502WPFCanvas;

class Center : IValueConverter
{
    const double RADIUS = 50;

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (double)value - RADIUS;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return (double)value + RADIUS;
    }
}
