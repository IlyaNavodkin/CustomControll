using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;

namespace CustomControll.Controls
{
    public partial class MultiSelectComboBox : UserControl
    {
        public MultiSelectComboBox()
        {

            InitializeComponent();
        }

        public static readonly DependencyProperty DisplayTextProperty =
            DependencyProperty.Register("DisplayText", typeof(string), typeof(MultiSelectComboBox), new PropertyMetadata(string.Empty));

        public string DisplayText
        {
            get => (string)GetValue(DisplayTextProperty);
            set => SetValue(DisplayTextProperty, value);
        }


        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(IEnumerable), typeof(MultiSelectComboBox), new PropertyMetadata(null));

        public IEnumerable ItemsSource
        {
            get => (IEnumerable)GetValue(ItemsSourceProperty);
            set => SetValue(ItemsSourceProperty, value);
        }

        public static readonly DependencyProperty SelectedItemsBindableProperty =
            DependencyProperty.Register("SelectedItemsBindable", typeof(IEnumerable), typeof(MultiSelectComboBox),
            new PropertyMetadata(null));

        public IEnumerable SelectedItemsBindable
        {
            get => (IEnumerable)GetValue(SelectedItemsBindableProperty);
            set => SetValue(SelectedItemsBindableProperty, value);
        }

        public static readonly DependencyProperty ItemTemplateProperty =
            DependencyProperty.Register("ItemTemplate", typeof(DataTemplate), typeof(MultiSelectComboBox), new PropertyMetadata(null));

        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }

        public ObservableCollection<object> SelectedItems { get; }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var items =  (sender as ListBox).SelectedItems;

            SelectedItemsBindable = items;
        }

    }
}
