namespace CrossCardGame.GameObjects
{
    public class Player
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string GenderPreference { get; private set; }

        public Player(int id, string name, string gender, string genderPreference)
        {
            ID = id;
            Name = name;
            Gender = gender;
            GenderPreference = genderPreference;
        }
    }
}