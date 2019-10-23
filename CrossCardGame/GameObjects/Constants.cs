using System.Collections.Generic;

namespace CrossCardGame.GameObjects
{
    public static class Constants
    {
        public static List<string> Genders { get; set; } = new List<string> {"Male", "Female"};
        public static List<string> SexualPreferences { get; set; } = new List<string> {"Straight", "Gay", "Lesbian", "Bi"};
        public static List<string> Punishment { get; set; } = new List<string> {"All", "Beer", "Dare", "Hard Liquor", "Weed"};
        
        public static List<string> Decks { get; set; } = new List<string>{"Level 1", "Level 2","Level 3","Level 4", "Level 5"};
    }
}