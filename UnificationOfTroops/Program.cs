using System;
using System.Collections.Generic;
using System.Linq;

namespace UnificationOfTroops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Army> troop1 = new List<Army>()
            {
                new Army("Петр", "Иванов"),
                new Army("Петр", "Боярский"),
                new Army("Иван", "Петров"),
                new Army("Василий", "Сидоров"),
                new Army("Евгений", "Большов"),
                new Army("Петр", "Туполев"),
            };

            List<Army> troop2 = new List<Army>()
            {
                new Army("Петр", "Петров"),
                new Army("Иван", "Иванов"),
                new Army("Василий", "Сидоров"),
                new Army("Евгений", "Туполев"),
            };


            Console.WriteLine("Отряд 1 до перевода:");
            foreach (var troop in troop1)
            {
                Console.WriteLine(troop.Firstname + " " + troop.Lastname);
            }

            Console.WriteLine("\nОтряд 2 до преревода:");
            foreach (var troop in troop2)
            {
                Console.WriteLine(troop.Firstname + " " + troop.Lastname);
            }


            var result1 = troop2.Union(troop1.OrderBy(troop => troop.Lastname).Where(troop => troop.Lastname.StartsWith("Б")));
            troop2 = result1.ToList();

            var result2 = troop1.OrderBy(troop => troop.Lastname).SkipWhile(troop => troop.Lastname.StartsWith("Б"));
            troop1 = result2.ToList();

            Console.WriteLine("\nОтряд 1 после преревода:");
            foreach (var troop in troop1)
            {
                Console.WriteLine(troop.Firstname + " " + troop.Lastname);
            }

            Console.WriteLine("\nОтряд 2 после преревода:");
            foreach (var troop in troop2)
            {
                Console.WriteLine(troop.Firstname + " " + troop.Lastname);
            }
        }
    }
}
