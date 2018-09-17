using System;
using BabyStepz.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace BabyStepz.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CameraPage : ContentPage
	{
		public CameraPage ()
		{
			InitializeComponent ();
		}

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            if (PhotoImage.Source != null)
            {
                
            }
        }

        private string SetImageFileName(string fileName = null)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                if (fileName != null)
                    CameraViewModel.ImageIdToSave = fileName;
                else
                    CameraViewModel.ImageIdToSave = CameraViewModel.DefaultImageId;

                return CameraViewModel.ImageIdToSave;
            }
            else
            {
                //To iterate, on iOS, if you want to save images to the devie, set 
                if (fileName != null)
                {
                    CameraViewModel.ImageIdToSave = fileName;
                    return fileName;
                }
                else
                    return null;
            }
        }
    }
}