using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaReference
{
    [ObservableObject]
    public partial class Section
    {
        [ObservableProperty]
        string _header = "";

        [ObservableProperty]
        bool _IsSelected;
    }
}