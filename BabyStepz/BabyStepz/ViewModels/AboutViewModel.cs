using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace BabyStepz.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://www.footstomp.studio")));
        }

        public ICommand OpenWebCommand { get; }
    }
}