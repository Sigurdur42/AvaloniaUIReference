using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using SkiaSharp;

namespace AvaloniaReference;

public class PredefinedSkiaColors
{
    static PredefinedSkiaColors()
    {
        var fields = typeof(SKColors).GetFields();
        Names = fields.Select(_ => _.Name).ToArray();

        var colors = new SKColors();
        var dict = new Dictionary<string, SKColor>();
        foreach (var field in fields)
        {
            var value = (SKColor)field.GetValue(colors);
            dict.Add(field.Name, value);
        }

        Colors = new ReadOnlyDictionary<string, SKColor>(dict);
    }

    public static string[] Names { get; }
    public static ReadOnlyDictionary<string, SKColor> Colors { get; }
}