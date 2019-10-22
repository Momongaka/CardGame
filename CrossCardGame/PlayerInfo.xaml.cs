using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using CrossCardGame.GameObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerInfo : ContentPage
    {
        public int PiD { get; set; }
        public PlayerInfo(int id)
        {
            PiD = id;
            InitializeComponent();

        }

        public PlayerInfo()
        {
            
        }
        
        private void AddtoParty(object sender, EventArgs e)
        {
            GameData.Instance.Party.Add(new Player(GameData.Instance.Party.Count() + 1, ChoicePlayerName.Text, ChoicePlayerGender.Text, ChoicePlayerSexualPreference.Text));
            Navigation.PushAsync(new PlayerSetup());
        }
        
        private void DeleteMe(object sender, EventArgs e)
        {
            var playerToDelete = GameData.Instance.Party.FirstOrDefault(a => a.IdNum == PiD);
            GameData.Instance.Party.Remove(playerToDelete);
            Navigation.PushAsync(new PlayerSetup());
        }
    }

}