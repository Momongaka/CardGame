using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NavigationPage = Xamarin.Forms.PlatformConfiguration.TizenSpecific.NavigationPage;

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