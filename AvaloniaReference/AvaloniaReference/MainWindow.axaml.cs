using Avalonia.Controls;
using System.Linq;

namespace AvaloniaReference
{
    public partial class MainWindow : Window
    {
        MainViewModel mainViewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();

            DataContext = mainViewModel;

        }

        private void OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
        {

            var selectedName = (e.AddedItems[0] as TreeViewItem)?.Name;
            var debug = 0;
        }
    }
}