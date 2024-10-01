using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace CustomControll.Controls
{
    public class SummaryCombobox : ComboBox
    {
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.Register("PlaceHolder", typeof(string), typeof(SummaryCombobox), new PropertyMetadata("Placeholder"));

        static SummaryCombobox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SummaryCombobox), new FrameworkPropertyMetadata(typeof(SummaryCombobox)));
        }

        public string PlaceHolder
        {
            get { return (string)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }
    }
}
