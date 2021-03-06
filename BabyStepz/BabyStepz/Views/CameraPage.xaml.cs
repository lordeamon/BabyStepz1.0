﻿using System;
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
  
        public CameraPage ()
		{
            InitializeComponent ();
		}

        private async void CameraButton_Clicked(object sender, EventArgs e)
        {
            //Inializes Camera and all its Functions
            await CrossMedia.Current.Initialize();

            //check the availability  and compatibility of the Camera
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                return;
            }

            //The camera opens, and then generates the info an detail of the image and saves it.
            var photo = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions()
            {
                Directory = CameraViewModel.DefaultImageDir,
                Name = CameraViewModel.DefImageId(),
                SaveToAlbum = CameraViewModel.SaveToAlbum                
            });

            //The taken photo is converted to a stream, the file disposed off, stream the sent to the display.
            if (photo != null)
            {
                PhotoImage.Source = ImageSource.FromStream(() => 
                {
                    var stream = photo.GetStream();
                    photo.Dispose();
                    return stream;

                });
            }
                
        }

        //A switch to toggle whether to save or not save the next taken photo
        private void SaveSwitch_Toggled(Switch sender, ToggledEventArgs e)
        {
          
            if (CameraViewModel.SaveToAlbum != sender.IsToggled)
            {
                CameraViewModel.SaveToAlbum = sender.IsToggled;
            }
        }

    }
}