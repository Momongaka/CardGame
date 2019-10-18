namespace CrossCardGame.GameObjects
{
    public class Game
    {
        private string PlayerA { get; set; }
        private string PlayerB { get; set; }

        public Game(string a, string b)
        {
            PlayerA = a;
            PlayerB = b;
        }
    }
}