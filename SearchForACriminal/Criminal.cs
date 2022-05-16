using System;

namespace Search_for_a_criminal
{
    internal class Criminal
    {
        public string _firstName { get; private set; }
        public string _lastName { get; private set; }
        public bool _isFree { get; private set; }
        public int _height { get; private set; }
        public int _weight { get; private set; }
        public string _nationality { get; private set; }

        public Criminal(string firstName, string lastName, int height, int weight, string nationality)
        {
            _firstName = firstName;
            _lastName = lastName;
            _height = height;
            _weight = weight;
            _nationality = nationality;
            _isFree = true;
        }

        public void TakeIntoCustody()
        {
            _isFree = false;
        }
    }
}
