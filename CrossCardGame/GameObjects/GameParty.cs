using System.Collections.ObjectModel;

namespace CrossCardGame.GameObjects
{
    public class GameParty
    {
        public ObservableCollection<Player> Party { get; set; }

        public GameParty()
        {
            Party = new ObservableCollection<Player>();
        }

        public void AddPlayerToParty(Player player)
        {
            Party.Add(player);
        }
    }
}