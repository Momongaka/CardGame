namespace CrossCardGame.GameObjects
{
    public class Player
    {
        public int IdNum { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string GenderPreference { get; private set; }
        
        //public string PlayerString => Name + " / " + Gender + " / " + GenderPreference;

        public Player()
        {
        }

        public Player(int id, string name, string gender, string genderPreference)
        {
            IdNum = id;
            Name = name;
            Gender = gender;
            GenderPreference = genderPreference;
        }
    }
}