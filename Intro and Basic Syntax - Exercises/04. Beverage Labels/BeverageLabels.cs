namespace _04.Beverage_Labels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BeverageLabels
    {
        public static void Main()
        {
            var productName = Console.ReadLine();
            var vlume = int.Parse(Console.ReadLine());
            var energyContent = double.Parse(Console.ReadLine());
            var sugarContent = double.Parse(Console.ReadLine());

            var energy = vlume * (energyContent / 100);
            var sugar = vlume * (sugarContent / 100);

            Console.WriteLine($"{vlume}ml {productName}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
