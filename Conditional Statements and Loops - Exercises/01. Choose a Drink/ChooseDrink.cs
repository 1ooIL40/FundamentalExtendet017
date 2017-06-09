namespace _01.Choose_a_Drink
{
    using System;

    public class ChooseDrink
    {
        public static void Main()
        {
            //Choose drink depeend on proffesion

            var profession = Console.ReadLine();

            switch (profession)
            {

                case "Athlete":
                    Console.WriteLine("Water");
                break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "Businesswoman":
                    Console.WriteLine("Coffee");
                    break;
                default:
                    Console.WriteLine("Tea");
                    break;
            }
        }
    }
}
