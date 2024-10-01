using System.Globalization;
using System.Windows.Data;

namespace CustomControll;

public class EnumToStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is FilterMode mode)
        {
            return FilterModeEnumHelper.GetDisplayName(mode);
        }
        return value.ToString();
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        foreach (FilterMode mode in Enum.GetValues(typeof(FilterMode)))
        {
            if (FilterModeEnumHelper.GetDisplayName(mode) == value.ToString())
            {
                return mode;
            }
        }
        return Binding.DoNothing;
    }
}