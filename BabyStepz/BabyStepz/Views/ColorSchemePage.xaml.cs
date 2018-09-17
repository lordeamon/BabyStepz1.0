using BabyStepz.Models;
using BabyStepz.Utilities;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace BabyStepz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorSchemePage : ContentPage
    {
 
        public ColorSchemePage()
        {
            InitializeComponent();

            colorSchemesList.ItemsSource = ColorSchemes.Schemes;

        }

        void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            Preferences.Intstance.ColorScheme = colorSchemesList.SelectedItem as ColorScheme;

            Navigation.PopAsync();
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Preferences.Intstance.ColorScheme = colorSchemesList.SelectedItem as ColorScheme;
        }

    }
}