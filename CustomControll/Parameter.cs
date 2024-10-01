using CommunityToolkit.Mvvm.ComponentModel;

namespace CustomControll;

public partial class Parameter : ObservableObject
{
    [ObservableProperty]
    private string _name;
}
