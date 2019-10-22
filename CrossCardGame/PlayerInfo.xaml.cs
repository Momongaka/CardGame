using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using CrossCardGame.GameObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace CrossCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerInfo : ContentPage
    {
        public int PiD { get; set; }
        public string Punish { get; set; }
        public PlayerInfo()
        {
            InitializeComponent();
        }
        public PlayerInfo(int id)
        {
            PiD = id;
        }
        private void AddParty(object sender, EventArgs e)
        {
            GameData.Instance.Party.Add(new Player(GameData.Instance.Party.Max(a => a.IdNum)+1, ChoicePlayerName.Text, ChoicePlayerGender.Text, ChoicePlayerSexualPreference.Text, "HI"));
            Navigation.PushAsync(new PlayerSetup());
        }
        
        private void DeleteMe(object sender, EventArgs e)
        {
            var playerToDelete = GameData.Instance.Party.FirstOrDefault(a => a.IdNum == PiD);
            GameData.Instance.Party.Remove(playerToDelete);
            Navigation.PushAsync(new PlayerSetup());
        }

        private void PunishMe(object sender, EventArgs e)
        {
            //Show confirmation dialog for choosing one or more.
                var result =  MaterialDialog.Instance.SelectChoiceAsync(title: "Select Your Punishments", confirmingText: "Save" , dismissiveText:"Cancel" ,selectedIndex: 0, choices: GameData.Instance.Punishment).Result;
                Punish = GameData.Instance.Punishment[result];
                //GameData.Instance.Punishment[result];
        }
        
    }

}