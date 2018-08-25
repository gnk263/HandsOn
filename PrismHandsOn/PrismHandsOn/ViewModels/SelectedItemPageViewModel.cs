using System;
using System.Reflection;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismHandsOn.ViewModels
{
    public class SelectedItemPageViewModel : BindableBase, INavigatingAware
    {
        private string _colorName;

        private Color _color;

        public string ColorName
        {
            get => _colorName;
            set => SetProperty(ref _colorName, value);
        }

        public Color Color
        {
            get => _color;
            set => SetProperty(ref _color, value);
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            ColorName = (string)parameters["colorName"];
            Color = (Color)typeof(Color).GetRuntimeField(ColorName).GetValue(null);
        }
    }
}