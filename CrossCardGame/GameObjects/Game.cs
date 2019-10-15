namespace CrossCardGame.GameObjects
{
    public class Game
    {
        public string PlayerA { get; private set; }
        public string PlayerB { get; private set; }

        public Game(string a, string b)
        {
            PlayerA = a;
            PlayerB = b;
        }
    }
}