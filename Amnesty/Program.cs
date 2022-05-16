using System;
using System.Collections.Generic;
using System.Linq;

namespace Amnesty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Criminal> criminals = new List<Criminal> { new Criminal("Иван", "Иванов", "Антиправительственное"),
                new Criminal("Петр", "Петров", "Убийство"),
                new Criminal("Иван", "Петров", "Антиправительственное"),
                new Criminal("Иван", "Сидоров", "Антиправительственное"),
                new Criminal("Петр", "Сидоров", "Убийство"),
            };


            Console.WriteLine("Преступники до амнистии:");
            foreach (var criminal in criminals)
            {
                Console.WriteLine(criminal.Firstname + " " + criminal.Lastname);
            }

            Console.WriteLine("\nПреступники после амнистии:");

            var newCriminals = criminals.Where(criminal => criminal.Crime != "Антиправительственное");

            foreach (var newCriminal in newCriminals)
            {
                Console.WriteLine(newCriminal.Firstname + " " + newCriminal.Lastname);
            }
        }
    }
}
