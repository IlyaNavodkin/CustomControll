using CustomControll;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Data;
namespace CustomControll.Controls;
public class ObservableCollectionConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ObservableCollection<ElementParameterValue> sourceCollection)
        {
            return new ObservableCollection<object>(sourceCollection.Cast<object>());
        }
        return null;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is ObservableCollection<object> sourceCollection)
        {
            return new ObservableCollection<ElementParameterValue>(sourceCollection.Cast<ElementParameterValue>());
        }
        return null;
    }
}