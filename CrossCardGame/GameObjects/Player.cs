namespace CrossCardGame.GameObjects
{
    public class Player
    {
        public int IdNum { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string SexualPreference { get; private set; }
        
        public string PlayerString => Name + " / " + Gender + " / " + SexualPreference;

        public Player()
        {
            
        }
        public Player(int id)
        {
            IdNum = id;
        }

        public Player(int id, string name, string gender, string sexualPreference)
        {
            IdNum = id;
            Name = name;
            Gender = gender;
            SexualPreference = sexualPreference;
        }
    }
}