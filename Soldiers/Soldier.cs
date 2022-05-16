using System;

namespace Soldiers
{
    internal class Soldier
    {
        public string Name { get; private set; }
        public string Armament { get; private set; }
        public string Rank { get; private set; }
        public int ServiceLife { get; private set; }

        public Soldier(string name, string armament, string rank, int serviceLife)
        {
            Name = name;
            Armament = armament;
            Rank = rank;
            ServiceLife = serviceLife;
        }
    }
}
