using System;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


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

            //Initializes the Mainpage - Start the application to the user
            InitializeComponent();
        }
    }
}