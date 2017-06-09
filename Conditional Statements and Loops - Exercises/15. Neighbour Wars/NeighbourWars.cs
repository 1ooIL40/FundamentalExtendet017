namespace _15.Neighbour_Wars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NeighbourWars
    {
        public static void Main()
        {
            var peshoDmg = int.Parse(Console.ReadLine());
            var goshoDmg = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;

            var peshoAbility = "Roundhouse kick";
            var goshoAbility = "Thunderous fist";
            var rounds = 0;

            for (int fight = 1; fight <= 100; fight++)
            {
                if (fight % 2 != 0)
                {
                    goshoHealth -= peshoDmg;
                    if (goshoHealth <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Pesho used {peshoAbility} and reduced Gosho to {goshoHealth} health.");
                    }
                }
                else if (fight % 2 == 0)
                {
                    peshoHealth -= goshoDmg;
                    if (peshoHealth <= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Gosho used {goshoAbility} and reduced Pesho to {peshoHealth} health.");
                    }
                }

                if(fight % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }

                rounds = fight;
            } 

            if(goshoHealth <= 0)
            {
                Console.WriteLine($"Pesho won in {rounds + 1}th round.");
            }
            else if(peshoHealth <= 0)
            {
                Console.WriteLine($"Gosho won in {rounds + 1}th round.");
            }
        }
    }
}
