using CommunityToolkit.Mvvm.ComponentModel;

namespace CustomControll;

public partial class Model : ObservableObject
{
    [ObservableProperty]
    private string _id = Guid.NewGuid().ToString();

    [ObservableProperty]
    private bool _isSelected;
}