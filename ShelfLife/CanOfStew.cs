using System;

namespace ShelfLife
{
    internal class CanOfStew
    {
        public string Name { get; private set; }
        public int ProductionYear { get; private set; }
        public int ShelfLive { get; private set; }

        public CanOfStew(string name, int productionYear, int shelfLive)
        {
            Name = name;
            ProductionYear = productionYear;
            ShelfLive = shelfLive;
        }
    }
}
