using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("Roboto-Light.ttf",Alias ="Robotolight")]
[assembly: ExportFont("Roboto-Medium.ttf", Alias = "Robotomedium")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "Robotoregular")]

namespace MobileAppUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
