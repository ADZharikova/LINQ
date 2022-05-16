using System;
using System.Collections.Generic;
using System.Linq;

namespace TopPlayers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>()
            {
                new Player("Su", 15, 20),
                new Player("Nj", 21, 20),
                new Player("Aa", 13, 22),
                new Player("Ab", 15, 0),
                new Player("Ac", 5, 1),
                new Player("Ad", 22, 18),
                new Player("Av", 9, 99),
                new Player("Az", 7, 3),
            };

            Console.WriteLine("Топ по уровням:");

            var filteredPlayersByLevel = players.OrderByDescending(player => player.Level).Take(3);

            foreach (var player in filteredPlayersByLevel)
            {
                Console.WriteLine(player.Username + " " + player.Level);
            }

            Console.WriteLine("\nТоп по силе:");

            var filteredPlayersByPower = players.OrderByDescending(player => player.Power).Take(3);

            foreach (var player in filteredPlayersByPower)
            {
                Console.WriteLine(player.Username + " " + player.Power);
            }
        }
    }
}
