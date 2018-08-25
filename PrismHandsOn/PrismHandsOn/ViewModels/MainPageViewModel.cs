using System;
using Prism.Mvvm;

namespace PrismHandsOn.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public string Message { get; } = "Hello, Prism for Xamarin.Forms!";

        public MainPageViewModel()
        {

        }
    }
}
