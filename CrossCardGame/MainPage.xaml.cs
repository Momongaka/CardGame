using System;
using Xamarin.Forms;

namespace CrossCardGame
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        async void OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PlayerSetup());
        }
    }
}