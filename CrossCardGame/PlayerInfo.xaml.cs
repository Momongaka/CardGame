using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using CrossCardGame.GameObjects;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Material.Forms;
using XF.Material.Forms.UI;
using XF.Material.Forms.UI.Dialogs;

namespace CrossCardGame
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerInfo : ContentPage
    {
        public Player Player { get; set; }
        public List<string> Punish { get; set; }

        public PlayerInfo()
        {
            InitializeComponent();
            ChoicePlayerGender.Choices = Constants.Genders;
            ChoicePlayerSexualPreference.Choices = Constants.SexualPreferences;
        }
        public PlayerInfo(Player player) : this()
        {
            Player = player;
        }
        private async void AddParty(object sender, EventArgs e)
        {
            if (Punish == null)
            {
                await MaterialDialog.Instance.AlertAsync("Select a Punishment");
                return;
            }
            if (Player != null)
                GameData.Instance.Party.Remove(Player);
            int index = 1;
            if (GameData.Instance.Party.Count > 0) index = GameData.Instance.Party.Max(a => a.IdNum) + 1;
            GameData.Instance.Party.Add(new Player(index, ChoicePlayerName.Text, ChoicePlayerGender.Text, ChoicePlayerSexualPreference.Text, ));
            await Navigation.PopModalAsync();
        }
        
        private async void DeleteMe(object sender, EventArgs e)
        {
            GameData.Instance.Party.Remove(Player);
            await Navigation.PopModalAsync();
        }

        private async void PunishMe(object sender, EventArgs e)
        {
            //Show confirmation dialog for choosing one or more.
            var result = await MaterialDialog.Instance.SelectChoicesAsync(title: "Select Your Punishments", selectedIndices: new int[] { 0 },
                choices: Constants.Punishment);
            if (result.Length == 0) return;
            Punish = result.Select(a => Constants.Punishment[a]).ToList();
            //GameData.Instance.Punishment[result];
        }
        
    }

}