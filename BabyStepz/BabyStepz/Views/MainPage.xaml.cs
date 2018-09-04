using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BabyStepz.Models;
using BabyStepz.ViewModels;
using BabyStepz.Utilities;

namespace BabyStepz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            //Android - Moves toolbar to bottom of the screen
            //Android - Enables Pagechange by swiping
            On<Xamarin.Forms.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Xamarin.Forms.PlatformConfiguration.Android>().EnableSwipePaging();

            Preferences.Intstance.ColorScheme = ColorSchemes.Schemes[0];

            //Initializes the Mainpage - Start the application to the user
            InitializeComponent();

            Preferences.Intstance.ColorSchemeUpdated += ColorSchemeUpdated;

            //to set the animations
            ColorSchemeUpdated(this, Preferences.Intstance.ColorScheme.SchemeType);
        }

        void ColorSchemeUpdated(object sender, ColorSchemeType e)
        {
            Color PrimColor = XFUtilities.GetColorFromInt(Preferences.Intstance.ColorScheme.PrimaryColor);
            Color PrimDarkColor = XFUtilities.GetColorFromInt(Preferences.Intstance.ColorScheme.PrimaryDarkColor);
            Color PrimLightColor = XFUtilities.GetColorFromInt(Preferences.Intstance.ColorScheme.PrimaryLightColor);
            Color PrimTextcolor = XFUtilities.GetColorFromInt(Preferences.Intstance.ColorScheme.PrimaryTextColor);
            Color AltTextColor = XFUtilities.GetColorFromInt(Preferences.Intstance.ColorScheme.AltTextColor);

            

            //imgLogo.Source = ImageSource.FromResource("BabyStepz.Images." + Preferences.Intstance.ColorScheme.Logo);
        }

        Color GetBlendedColor(Color color1, Color color2, double percentage)
        {
            return new Color(percentage * color1.R + (1 - percentage) * color2.R,
                             percentage * color1.G + (1 - percentage) * color2.G,
                             percentage * color1.B + (1 - percentage) * color2.B);
        }
    }
}