using System;
using Prism.Mvvm;

namespace PrismHandsOn.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public string _message = "Hello, Prism for Xamarin.Forms!";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public MainPageViewModel()
        {

        }
    }
}
