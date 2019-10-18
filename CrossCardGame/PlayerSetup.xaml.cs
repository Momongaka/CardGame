using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerSetup : ContentPage
    {
        public PlayerSetup()
        {
            InitializeComponent();
        }

        private void MaterialCard_OnClicked(object sender, EventArgs e)
        {
        }
    }
}