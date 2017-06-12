namespace _03.Printing_Triangle
{
    using System;

    public class PrintingTriangle
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                PrintLine(1, i);
            }

            PrintLine(1, number);

            for (int i = number - 1; i >= 0; i--)
            {
                PrintLine(1, i);
            }

        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
