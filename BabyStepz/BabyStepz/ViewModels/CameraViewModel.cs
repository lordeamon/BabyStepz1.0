using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace BabyStepz.ViewModels
{
    public class CameraViewModel : BaseViewModel
    {
        public static string DefaultImageId;
        public static string DefaultImageDir = "BabyStepz";
        public static bool SaveToAlbum;

        public CameraViewModel()
        {
            Title = "Simple Camera Sample";
            SaveToAlbum = true;
           
        }


        public static string DefImageId()
        {
            string newID = DateTime.Now + ".jpg";
            DefaultImageId = newID;
            return DefaultImageId;
        }

    }
}