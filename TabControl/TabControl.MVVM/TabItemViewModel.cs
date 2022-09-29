﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace TabControl.MVVM;

[ObservableObject]
public partial class TabItemViewModel
{
    [ObservableProperty]
    private string? _title;
}

public partial class OtherTabViewModel : TabItemViewModel
{

}