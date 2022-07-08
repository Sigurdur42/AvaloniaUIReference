using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaReference
{
    [ObservableObject]
    public partial class MainViewModel
    {
        public MainViewModel()
        {
        }

        public SelectedPage SelectedPage { get; } = new SelectedPage();
        public string Title { get; set; } = "Welcome Michael";
    }
}