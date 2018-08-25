using System;
using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace PrismHandsOn.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public string _message = "Hello, Prism for Xamarin.Forms!";
        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }

        public ICommand UpdateMessageCommand => new Command(() => Message = $"Updated on {DateTime.Now}");

        public ICommand AppearingCommand => new Command(() => Message = $"Appearing on {DateTime.Now}");

        public Command<string> NavigateCommand =>
            new Command<string>(
                name => _navigationService.NavigateAsync(name));

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
