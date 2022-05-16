using System;

namespace UnificationOfTroops
{
    internal class Army
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }

        public Army(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
