using System;
using BabyStepz.ViewModels;
using BabyStepz.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;


namespace BabyStepz.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CameraPage : ContentPage
	{
        public bool SaveToAlbum;
		public CameraPage ()
		{
            SaveToAlbum = false;
            InitializeComponent ();
		}

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                return;
            }

            var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions()
            {
                Directory = "BabyStepz",
                Name = DateTime.Now +".jpg",
                SaveToAlbum = SaveToAlbum
                
            });

            if (photo != null)
                PhotoImage.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
        }

        

        private void SaveSwitch_Toggled(Switch sender, ToggledEventArgs e)
        {
          
            if (SaveToAlbum != sender.IsToggled)
            {
                SaveToAlbum = sender.IsToggled;
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