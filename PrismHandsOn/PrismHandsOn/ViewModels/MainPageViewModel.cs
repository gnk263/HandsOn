using System;
using System.Windows.Input;
using Prism.Mvvm;
using Xamarin.Forms;

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

        public ICommand UpdateMessageCommand => new Command(() => Message = $"Updated on {DateTime.Now}");

        public MainPageViewModel()
        {

        }
    }
}
