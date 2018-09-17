using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace BabyStepz.ViewModels
{
    public class CameraViewModel : BaseViewModel
    {
        public static string DefaultImageId = "default_image";
        public static string ImageIdToSave = null;

        public CameraViewModel()
        {
            Title = "Simple Camera Sample";
           
        }

    }
}