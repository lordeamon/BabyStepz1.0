using BabyStepz.Utilities;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BabyStepz.Models
{
    public class ColorScheme
    {
        public ColorSchemeType SchemeType { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Square { get; set; }
        public int PrimaryColor { get; set; }
        public int PrimaryDarkColor { get; set; }
        public int PrimaryLightColor { get; set; }
        public int PrimaryTextColor { get; set; }
        public int AltTextColor { get; set; }

    }
}
