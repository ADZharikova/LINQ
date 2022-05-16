using System;

namespace Amnesty
{
    internal class Criminal
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Crime { get; private set; }

        public Criminal(string firstname, string lastname, string crime)
        {
            Firstname = firstname;
            Lastname = lastname;
            Crime = crime;
        }
    }
}
