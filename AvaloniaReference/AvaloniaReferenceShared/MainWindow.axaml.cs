using Avalonia.Controls;

namespace AvaloniaReference
{
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = mainViewModel;
        }

        private void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
        {
            var page = AvailablePages.Home;
            var selectedName = (e.AddedItems[0] as TreeViewItem)?.Header?.ToString();
            page = (selectedName?.ToLowerInvariant()) switch
            {
                "button" => AvailablePages.Button,
                "controls" => AvailablePages.Controls,
                "charts" => AvailablePages.Charts,
                "donut" => AvailablePages.ChartDonut,
                "line" => AvailablePages.ChartLine,
                _ => AvailablePages.Home,
            };
            mainViewModel.SelectedPage.SetCurrentPage(page);
        }
    }
}