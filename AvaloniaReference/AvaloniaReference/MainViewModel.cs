using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaReference
{
    [ObservableObject]
    public partial class MainViewModel
    {
        public MainViewModel()
        {
            Sections = new[]
            {
                new Section{ Header ="Main"},
                new Section{ Header ="Sub 1"},
                new Section{ Header ="very long Sub 2"},
            };
        }

        public string Title { get; set; } = "Welcome Michael";

        public Section[] Sections { get; }
    }
}