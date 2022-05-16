using System;
using System.Collections.Generic;
using System.Linq;

namespace ShelfLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<CanOfStew> canOfStews = new List<CanOfStew>()
            {
                new CanOfStew("Aa", 2005, 12),
                new CanOfStew("Ab", 2003, 4),
                new CanOfStew("Ac", 2012, 15),
                new CanOfStew("Ad", 2012, 2),
                new CanOfStew("Ae", 2013, 10),
                new CanOfStew("Af", 2010, 4),
                new CanOfStew("Ag", 2020, 2),
                new CanOfStew("Ah", 2000, 9),
            };
            int newYear = 2022;

            var expiredCanOfStews = canOfStews.Where(canOfStew => (canOfStew.ProductionYear +canOfStew.ShelfLive) < newYear).ToList();

            Console.WriteLine("Просроченные банки:");
            foreach (var canOfStew in expiredCanOfStews)
            {
                Console.WriteLine(canOfStew.Name);
            }
        }
    }
}
