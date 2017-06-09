namespace _05.Character_Stats
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CharacterStats
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var healthBar = new string('|', currentHealth) + new string('.', (maxHealth - currentHealth));
            var energyBar = new string('|', currentEnergy) + new string('.', (maxEnergy - currentEnergy));

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthBar}|");
            Console.WriteLine($"Energy: |{energyBar}|");
        }
    }
}
