using System;

namespace TopPlayers
{
    internal class Player
    {
        public string Username { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }

        public Player(string username, int level, int power)
        {
            Username = username;
            Level = level;
            Power = power;
        }
    }
}
