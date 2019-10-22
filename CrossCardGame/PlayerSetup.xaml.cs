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
        
        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PlayerInfo());
            // TODO spawn a new window to make a Player
            //GameData.Instance.Party.Add(new Player(1, "Fred", "Male", "Female"));
        }

        private void MaterialCard_OnClicked(object sender, EventArgs e)
        {
            var item = sender as MaterialCard;
            if (item == null) return;
            var player = item.BindingContext as Player;
            if (player == null) return;
            // destroy all humans
        }
    }
}