using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaReference
{
    [ObservableObject]
    public partial class SelectedPage
    {
        public AvailablePages CurrentPage { get; private set; }

        public bool IsButton => CurrentPage == AvailablePages.Button;
        public bool IsControls => CurrentPage == AvailablePages.Controls;
        public bool IsCharts => CurrentPage == AvailablePages.Charts;
        public bool IsChartDonut => CurrentPage == AvailablePages.ChartDonut;
        public bool IsChartLine => CurrentPage == AvailablePages.ChartLine;
        public bool IsHome => CurrentPage == AvailablePages.Home;

        public void SetCurrentPage(AvailablePages page)
        {
            if (page == CurrentPage)
            {
                return;
            }

            CurrentPage = page;
            OnPropertyChanged(nameof(CurrentPage));
            OnPropertyChanged(nameof(IsHome));
            OnPropertyChanged(nameof(IsButton));
            OnPropertyChanged(nameof(IsControls));
            OnPropertyChanged(nameof(IsCharts));
            OnPropertyChanged(nameof(IsChartDonut));
            OnPropertyChanged(nameof(IsChartLine));
        }
    }
}