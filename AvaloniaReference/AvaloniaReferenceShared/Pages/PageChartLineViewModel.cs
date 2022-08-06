using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace AvaloniaReference.Pages;

[ObservableObject]
public partial class PageChartLineViewModel
{
    public string[] ColorNames => PredefinedSkiaColors.Names;
    public ReadOnlyDictionary<string, SKColor> Colors => PredefinedSkiaColors.Colors;
    
    public ISeries[] Series { get; set; }
        = {
            new LineSeries<double>
            {
                Values = new double[]
                {
                    2,
                    1,
                    3,
                    5,
                    3,
                    4,
                    6
                },
                Fill = null
            },

            new LineSeries<double>
            {
                Values = new double[]
                {
                    12,
                    11,
                    1,
                    15,
                    13,
                    14,
                    16
                },
                Fill = null,
                Stroke = new SolidColorPaint(SKColors.Blue)
                {
                    StrokeThickness = 2
                },
                GeometryStroke = new SolidColorPaint(SKColors.GreenYellow)
                {
                    StrokeThickness = 2
                },
                GeometrySize = 4,
            }
        };

    
}