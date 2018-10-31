using BabyStepz.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BabyStepz.Utilities
{
    public enum ColorSchemeType
    {

        Purple,
        Turquoise,
        Blue,
        Autumn,
        count
    }


    public static class ColorSchemes
    {
        public static IList<ColorScheme> Schemes { get; private set; }

        static ColorSchemes()
        {
            Schemes = new ObservableCollection<ColorScheme>
            {
                new ColorScheme()
                {
                    SchemeType = ColorSchemeType.Purple,
                    Name = "Purple Colors",
                    Square = "logo.png",
                    Logo = "logo.png",
                    PrimaryColor = 0x010b1c,
                    PrimaryDarkColor = 0x4a0072,
                    PrimaryLightColor = 0xae52d4,
                    PrimaryTextColor =0xFFFFFF ,
                    AltTextColor = 0xBFBBBB,
                    
                },

                new ColorScheme()
                {
                    SchemeType = ColorSchemeType.Turquoise,
                    Name = "Turquoise Colors",
                    Square = "logo.png",
                    Logo = "logo.png",
                    PrimaryColor = 0x159c7e,
                    PrimaryDarkColor = 0xdf7e1c,
                    PrimaryLightColor = 0xec5353,
                    PrimaryTextColor =0xFFFFFF ,
                    AltTextColor = 0xBFBBBB,

                },

                new ColorScheme()
                {
                    SchemeType = ColorSchemeType.Blue,
                    Name = "Blue Colors",
                    Square = "logo.png",
                    Logo = "logo.png",
                    PrimaryColor = 0x0B132B,
                    PrimaryDarkColor = 0x1C2541,
                    PrimaryLightColor = 0x3A506B,
                    PrimaryTextColor =0xFFFFFF ,
                    AltTextColor = 0xBFBBBB,

                },

                new ColorScheme()
                {
                    SchemeType = ColorSchemeType.Autumn,
                    Name = "Blue Colors",
                    Square = "logo.png",
                    Logo = "logo.png",
                    PrimaryColor = 0x003049,
                    PrimaryDarkColor = 0xD62828,
                    PrimaryLightColor = 0xF77F00,
                    PrimaryTextColor =0xFCBF49 ,
                    AltTextColor = 0xEAE2B7,

                },


            };
        }

    }
}
