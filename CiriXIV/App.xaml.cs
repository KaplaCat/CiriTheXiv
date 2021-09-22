using CiriXIV.ViewModel.Base;
using CiriXIV.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CiriXIV
{
    public partial class App : Application
    {
        static App()
        {
            Locator.Instance.Build();
        }

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
