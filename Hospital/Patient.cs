using System;

namespace Hospital
{
    internal class Patient
    {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public int Age { get; private set; }
        public string Disease { get; private set; }

        public Patient(string firstname, string lastname, int age, string disease)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Disease = disease;
        }
    }
}
