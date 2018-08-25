using System;
using Prism;
using Prism.Ioc;
using PrismHandsOn.Views;
using Xamarin.Forms;

namespace PrismHandsOn
{
    public partial class App
    {
        public App()
        {
        }

        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<ColorsPage>();
            containerRegistry.RegisterForNavigation<SelectedItemPage>();
        }

        protected override void OnInitialized()
        {
            NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");
        }
    }
}
