using System;
using System.Collections.ObjectModel;
using CrossCardGame.GameObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace CrossCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerSetup : ContentPage
    {
        public PlayerSetup()
        {
            InitializeComponent();
        }
        
        private async void AddPlayer(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new PlayerInfo());
        }

        private async void MaterialCard_OnClicked(object sender, EventArgs e)
        {

            var item = sender as MaterialCard;
            if (item == null) return;
            var player = item.BindingContext as Player;
            if (player == null) return;
            // destroy all humans
            await Navigation.PushModalAsync(new PlayerInfo(player));
        }

        private void StartGame(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new DeckChoice());
        }
    }
}