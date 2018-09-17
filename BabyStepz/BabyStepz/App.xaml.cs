using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BabyStepz.Views;
using BabyStepz.Models;
using BabyStepz.Utilities;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BabyStepz
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static void UpdateThemeColors(ColorScheme scheme)
        {
            Current.Resources["PrimaryColor"] = XFUtilities.GetColorFromInt(scheme.PrimaryColor);
            Current.Resources["PrimaryDarkColor"] = XFUtilities.GetColorFromInt(scheme.PrimaryDarkColor);
            Current.Resources["PrimaryLightColor"] = XFUtilities.GetColorFromInt(scheme.PrimaryLightColor);
            Current.Resources["PrimaryTextColor"] = XFUtilities.GetColorFromInt(scheme.PrimaryTextColor);
            Current.Resources["AltTextColor"] = XFUtilities.GetColorFromInt(scheme.AltTextColor);


        }
    }
}
