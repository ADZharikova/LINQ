using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_criminal
{
    internal class DatabaseOfCriminals
    {
        private List<Criminal> _criminals = new List<Criminal>();

        public void AddCriminal(string firstName, string lastName, int height, int weight, string nationality)
        {
            _criminals.Add(new Criminal(firstName, lastName, height, weight, nationality));
        }

        public void Check(int height, int weight, string nationality)
        {
            var filteredCriminals = _criminals.Where(criminal => criminal._height == height && criminal._weight == weight && criminal._nationality == nationality && criminal._isFree);

            foreach (var filteredCriminal in filteredCriminals)
            {
                Console.WriteLine(filteredCriminal._firstName + " " + filteredCriminal._lastName);
            }
        }

        public void TakeIntoCustody(string firstName, string lastName)
        {
            foreach (var criminal in _criminals)
            {
                if (criminal._firstName == firstName && criminal._lastName == lastName)
                criminal.TakeIntoCustody();
            }
        }
    }
}
