namespace _01.Choose_a_Drink
{
    using System;

    public class ChooseDrinkTwo
    {
        public static void Main()
        {
            //Choose drink depeend on proffesion and quantitie price

            var profession = Console.ReadLine();
            var quantiti = int.Parse(Console.ReadLine());

            switch (profession)
            {

                case "Athlete":
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 0.70):f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 1.70):f2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 1.00):f2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 1.00):f2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {(quantiti * 1.20):f2}.");
                    break;
            }
        }
    }
}
