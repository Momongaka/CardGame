using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CrossCardGame.GameObjects
{
    public class GameData
    {
        private static GameData _instance = null;
        
        // This is called a singleton. It will always be defined, and there will only ever be one of it.
        public static GameData Instance
        {
            get
            {
                // This can be simplified, and rider will want you to, but it becomes
                // public static GameData Instance => _instance ?? (_instance = new GameData());
                // which is hard to read
                if (_instance == null) _instance = new GameData();
                return _instance;
            }
        }

        public ObservableCollection<Player> Party { get; set; }
        
        public Queue<string>[] Decks { get; set; }

        private GameData()
        {
            Decks = new Queue<string>[5];
            Party = new ObservableCollection<Player>();
            for (int i = 0; i < Decks.Length; i++)
            {
                Decks[i] = new Queue<string>();
            }
        }
    }
}