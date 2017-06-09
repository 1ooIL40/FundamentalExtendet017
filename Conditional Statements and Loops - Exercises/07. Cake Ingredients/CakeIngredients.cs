namespace _07.Cake_Ingredients
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CakeIngredients
    {
        public static void Main()
        {
            var ingredients = Console.ReadLine();
            var countIngredients = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                countIngredients++;
                ingredients = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {countIngredients} ingredients.");
        }
    }
}
