using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace AvaloniaReference
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            
            LiveCharts.Configure(config => 
                    config 
                        // registers SkiaSharp as the library backend
                        // REQUIRED unless you build your own
                        .AddSkiaSharp() 

                        // adds the default supported types
                        // OPTIONAL but highly recommend
                        .AddDefaultMappers() 

                        // select a theme, default is Light
                        // OPTIONAL
                        //.AddDarkTheme()
                        .AddLightTheme() 

                        // // finally register your own mappers
                        // // you can learn more about mappers at:
                        // // ToDo add website link...
                        // .HasMap<City>((city, point) =>
                        // {
                        //     point.PrimaryValue = city.Population;
                        //     point.SecondaryValue = point.Context.Index;
                        // })
                // .HasMap<Foo>( .... )
                // .HasMap<Bar>( .... )
            );
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
