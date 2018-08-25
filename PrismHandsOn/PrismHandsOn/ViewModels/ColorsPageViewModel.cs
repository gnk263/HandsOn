using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace PrismHandsOn.ViewModels
{
    public class ColorsPageViewModel
    {
        public IReadOnlyCollection<ColorInfo> ColorInfos { get; } =
            typeof(Color)
                .GetRuntimeFields()
                .Where(x => x.IsPublic && x.IsStatic && x.FieldType == typeof(Color))
                .Select(x => new ColorInfo { Name = x.Name, Color = (Color)x.GetValue(null) })
                .ToList();
    }
}
