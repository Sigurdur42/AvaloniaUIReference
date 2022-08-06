using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaReference.Pages;

public partial class PageChartLine : UserControl
{
    private readonly PageChartLineViewModel viewModel = new();
    public PageChartLine()
    {
        InitializeComponent();
        DataContext = viewModel;
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}