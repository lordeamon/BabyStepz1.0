using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BabyStepz.Models;

namespace BabyStepz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();

            Item = new Item
            {
                Text = "Item name",
                Description = "This is an item description."
            };

            BindingContext = this;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "AddItem", Item);
            await Navigation.PopModalAsync();
        }

        async void Cancel_Clicked(object sender, EventArgs e)
        {

            var answer = await DisplayAlert("Alert", "Cancel your post?", "Yes", "No");

            if (answer)
            {
                await Navigation.PopModalAsync();
            }
            else if (!answer)
            {

            }
            

            
            
        }

        private void Entry_Focused(Entry sender, FocusEventArgs e)
        {
            sender.Text = "";
           
        }

        private void Editor_Focused(Editor sender, FocusEventArgs e)
        {
            sender.Text = "";
        }

    }
}