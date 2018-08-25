using System;
using Prism.Ioc;
using PrismHandsOn.Views;
using Xamarin.Forms;

namespace PrismHandsOn
{
    public partial class App
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ColorsPage>();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");
        }
    }
}
