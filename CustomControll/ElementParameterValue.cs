using CommunityToolkit.Mvvm.ComponentModel;

namespace CustomControll;

public partial class ElementParameterValue: ObservableObject
{
    [ObservableProperty]
    private string _value;

    [ObservableProperty]
    private bool _isSelected;
}
