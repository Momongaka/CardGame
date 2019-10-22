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
        public PlayerInfo()
        {
            InitializeComponent();

        }
        
        private void Button_OnClicked(object sender, EventArgs e)
        {
            GameData.Instance.Party.Add(new Player(GameData.Instance.Party.Count() + 1, ChoicePlayerName.Text,
                ChoicePlayerGender.Text, ChoicePlayerSexualPreference.Text));
            Navigation.PushAsync(new PlayerSetup());
        }
    }

}