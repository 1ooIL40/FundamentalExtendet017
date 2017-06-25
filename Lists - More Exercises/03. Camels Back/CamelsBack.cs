namespace _03.Camels_Back
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var buildings = Console.ReadLine()
                .Split(new char[] { ' ' })
                .Select(int.Parse)
                .ToList();

            var camelsBackSize = int.Parse(Console.ReadLine());


            if(buildings.Count <= camelsBackSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ",buildings)}");
            }
            else
            {
                var rouds = (buildings.Count - camelsBackSize) / 2;


                buildings = buildings
                    .Skip(rouds)
                    .Take(camelsBackSize)
                    .ToList();

                Console.WriteLine($"{rouds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
        }
    }
}
