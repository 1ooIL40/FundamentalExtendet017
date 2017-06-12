namespace _04.Draw_a_Filled_Square
{
    using System;

    public class DrawAFilledSquare
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            PrintHeaderRow(number);

            for (int i = 0; i < number -2; i++)
            {
                PrintBodyRow(number);
            }

            PrintHeaderRow(number);

        }

        static void PrintBodyRow(int number)
        {
            Console.Write("-");

            for (int i = 1; i < number; i++)
            {
                Console.Write("\\/");
            }

            Console.WriteLine("-");
        }

        static void PrintHeaderRow(int number)
        {
            Console.WriteLine(new string ('-', number*2));
        }
    }
}
