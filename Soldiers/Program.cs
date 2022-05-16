using System;
using System.Collections.Generic;
using System.Linq;

namespace Soldiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Soldier> soldiers = new List<Soldier>()
            {
                new Soldier("Aa", "Ba", "Ra", 12),
                new Soldier("Ab", "Bb", "Rb", 2),
                new Soldier("Ac", "Bc", "Rc", 23),
                new Soldier("Ad", "Bd", "Rd", 10),
            };

            Console.WriteLine("Старый список:");
            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.Name + " " + soldier.Armament + " " +soldier.Rank +" " + soldier.ServiceLife);
            }

            var newSoldiers = soldiers.Select(soldier => new
            {
                Name = soldier.Name,
                Rank = soldier.Rank
            }).ToList();

            Console.WriteLine("\nНовый список:");
            foreach (var newSoldier in newSoldiers)
            {
                Console.WriteLine(newSoldier.Name + " " + newSoldier.Rank);
            }
        }
    }
}
