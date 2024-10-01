using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Linq;

namespace CustomControll;

public partial class FilterItemViewModel : ObservableObject
{
    [ObservableProperty]
    public FilterMode _selectedGroupFilterMode;

    [ObservableProperty]
    public Parameter _parameter;

    [ObservableProperty]
    public ObservableCollection<ElementParameterValue> _elementParameterValues = new ObservableCollection<ElementParameterValue>();


    private ObservableCollection<ElementParameterValue> _selectedElementParameterValues;
    public ObservableCollection<ElementParameterValue> SelectedElementParameterValues
    {
        get => _selectedElementParameterValues;
        set => SetProperty(ref _selectedElementParameterValues, value);
    }

    partial void OnElementParameterValuesChanged(ObservableCollection<ElementParameterValue>? oldValue, ObservableCollection<ElementParameterValue> newValue)
    {
        if (oldValue is not null)
        {
            foreach (var item in oldValue)
            {
                item.PropertyChanged -= ElementParameterValueChanged;
            }
        }

        if (newValue is not null)
        {
            foreach (var item in newValue)
            {
                item.PropertyChanged += ElementParameterValueChanged;
            }
        }
    }

    private void ElementParameterValueChanged(object? sender, PropertyChangedEventArgs e)
    {
        UpdateSelectedItemsText();
    }

    private void UpdateSelectedItemsText()
    {
        var summaryText = string.Join(", ", ElementParameterValues.Where(e => e.IsSelected).Select(e => e.Value));

        if (string.IsNullOrEmpty(summaryText)) summaryText = "Выберите значения";

        SelectedItemsText = summaryText;
    }

    [ObservableProperty]

    private string _selectedItemsText;

    partial void OnParameterChanged(Parameter value)
    {
        ElementParameterValues = GetValues();
        OnPropertyChanged(nameof(SelectedItemsText));

        UpdateSelectedItemsText();
    }

    private ObservableCollection<ElementParameterValue> GetValues()
    {
        return new ObservableCollection<ElementParameterValue>
        {
            new ElementParameterValue{ Value = "В1" },
            new ElementParameterValue{ Value = "В12" },
            new ElementParameterValue{ Value = "П1" },
            new ElementParameterValue{ Value = "П41" },
            new ElementParameterValue{ Value = "Н1" },
            new ElementParameterValue{ Value = "укцу1" },
            new ElementParameterValue{ Value = "В2" }
        };
    }
}
