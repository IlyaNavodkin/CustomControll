using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CustomControll;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Parameter> _avalableParameters;

    [ObservableProperty]
    private ObservableCollection<FilterItemViewModel> _filterItems = new ObservableCollection<FilterItemViewModel>();

    [RelayCommand]
    private void AddNewFilter()
    {
        FilterItems.Add(new FilterItemViewModel());
    }

    [RelayCommand]
    private void RemoveLastFilter()
    {
        if (FilterItems.Count > 0)
        {
            FilterItems.RemoveAt(FilterItems.Count - 1);
        }
    }

    public MainWindowViewModel() 
    {
        _avalableParameters = new ObservableCollection<Parameter> 
        { 
            new Parameter
            {
                Name = "SPA_Name"
            },
            new Parameter
            {
                Name = "SPA_Mark"
            },
            new Parameter
            {
                Name = "SPA_Count"
            },
        };

        _filterItems = new ObservableCollection<FilterItemViewModel>
        {
            new FilterItemViewModel
            {
                Parameter = AvalableParameters.FirstOrDefault(),
                SelectedGroupFilterMode = FilterMode.Equals
            },
            new FilterItemViewModel
            {
                Parameter = AvalableParameters.FirstOrDefault(),
                SelectedGroupFilterMode = FilterMode.NotEquals
            }
        };
    }
}
