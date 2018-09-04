using BabyStepz.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BabyStepz.ViewModels
{
    public enum ColorSchemeType
    {

        Primary,
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
                    SchemeType = ColorSchemeType.Primary,
                    Name = "Primary Colors",
                    Square = "logo.png",
                    Logo = "logo.png",
                    PrimaryColor = 0x010b1c,
                    PrimaryDarkColor = 0x4a0072,
                    PrimaryLightColor = 0xae52d4,
                    PrimaryTextColor =0xFFFFFF ,
                    AltTextColor = 0xBFBBBB,

                    
                },

                
            };
        }

    }
}
