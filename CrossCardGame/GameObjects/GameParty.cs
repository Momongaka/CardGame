using System.Collections.ObjectModel;

namespace CrossCardGame.GameObjects
{
    public class GameParty
    {
        public static ObservableCollection<Player> Party { get; set; }

        public GameParty()
        {
            Party = new ObservableCollection<Player>();
            Party.Add(new Player(1,"Daniel","M","F"));
        }

        public void AddPlayerToParty(Player player)
        {
            Party.Add(player);
        }
    }
}