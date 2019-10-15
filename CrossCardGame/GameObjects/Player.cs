namespace CrossCardGame.GameObjects
{
    public class Player
    {
        public string Name { get; private set; }
        public int ID { get; private set; }

        public Player(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}