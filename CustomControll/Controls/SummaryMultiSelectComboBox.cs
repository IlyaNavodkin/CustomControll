using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace CustomControll.Controls;

public class SummaryMultiSelectComboBox : ComboBox
{
    public static readonly DependencyProperty SelectedItemsTextProperty =
        DependencyProperty.Register("SelectedItemsText", typeof(string), typeof(SummaryMultiSelectComboBox), new PropertyMetadata(string.Empty));

    public string SelectedItemsText
    {
        get => (string)GetValue(SelectedItemsTextProperty);
        set => SetValue(SelectedItemsTextProperty, value);
    }

    public SummaryMultiSelectComboBox()
    {
        // Установка стиля и шаблона по умолчанию
        DefaultStyleKey = typeof(SummaryMultiSelectComboBox);
    }
}
