using System;
using System.Collections.ObjectModel;
using CrossCardGame.GameObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerSetup : ContentPage
    {
        public ObservableCollection<Player> ObserveParty = new ObservableCollection<Player>(GameParty.Party);
        public PlayerSetup()
        {
            InitializeComponent();
            
        }
        
        private void Button_OnClicked(object sender, EventArgs e)
        {
            
        }
    }
}